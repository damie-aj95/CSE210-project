using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /*
    * Added support for multiple scriptures, progress display,
    * and verse ranges.
    */

    // Scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths"
            ),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me"
            ),
            new Scripture(
                new Reference("1 Nephi", 3, 7),
                "I will go and do the things which the Lord hath commanded for I know that the Lord giveth no commandments unto the children of men save he shall prepare a way for them"
            )
        };

        // Randomly select a scripture
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        Console.WriteLine("Welcome to the Scripture Memorizer.");
        Console.WriteLine("Press Enter to begin.");
        Console.ReadLine();

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            int remainingWords = scripture.GetVisibleWordCount();
            if (remainingWords > 0)
            {
                Console.WriteLine($"Words remaining: {remainingWords}");
                Console.WriteLine();
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are now hidden. Well done!");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            Console.Write("Press Enter to hide more words or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye. Keep practicing!");
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
