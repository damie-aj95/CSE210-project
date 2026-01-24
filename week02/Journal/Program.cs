using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            bool valid = int.TryParse(Console.ReadLine(), out choice);

            if (!valid)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;
            }

            if (choice == 1)
            {
                Entry entry = new Entry();
                entry.Date = DateTime.Now.ToShortDateString();
                entry.PromptText = promptGenerator.GetRandomPrompt();

                Console.WriteLine(entry.PromptText);
                Console.Write("> ");
                entry.EntryText = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename to load: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                Console.WriteLine("Journal loaded.");
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to save: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine("Journal saved.");
            }
        }

        // Exceeded requirements by:
        // - Using abstraction with separate Entry, Journal, and PromptGenerator classes
        // - Encapsulating file I/O inside the Journal class
        // - Keeping Program.cs focused only on user interaction
        // - Added validation to prevent crashes from invalid menu input
    }
}
