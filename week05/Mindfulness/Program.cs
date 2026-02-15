// Exceeded core requirements by using inheritance and polymorphism.
// All activities inherit from a base Activity class and override Run(),
// allowing shared structure and easy extensibility.

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();

            if (choice == "1") new BreathingActivity().Run();
            else if (choice == "2") new ReflectingActivity().Run();
            else if (choice == "3") new ListingActivity().Run();
            else if (choice == "4") break;
        }
    }
}
