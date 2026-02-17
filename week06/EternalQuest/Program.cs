using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Eternal Quest Program ===");
            manager.DisplayScore();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;

                case "2":
                    manager.DisplayGoals();
                    break;

                case "3":
                    RecordEvent(manager);
                    break;

                case "4":
                    Console.Write("What is the filename for the goal file? ");
                    manager.Save(Console.ReadLine());
                    break;

                case "5":
                    Console.Write("What is the filename for the goal file? ");
                    manager.Load(Console.ReadLine());
                    break;

                case "6":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option! Please try again.");
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid points value!");
            return;
        }

        switch (choice)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, description, points));
                Console.WriteLine("Simple goal created successfully!");
                break;

            case "2":
                manager.AddGoal(new EternalGoal(name, description, points));
                Console.WriteLine("Eternal goal created successfully!");
                break;

            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                if (!int.TryParse(Console.ReadLine(), out int target))
                {
                    Console.WriteLine("Invalid target count!");
                    return;
                }

                Console.Write("What is the bonus for accomplishing it that many times? ");
                if (!int.TryParse(Console.ReadLine(), out int bonus))
                {
                    Console.WriteLine("Invalid bonus value!");
                    return;
                }

                manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                Console.WriteLine("Checklist goal created successfully!");
                break;

            default:
                Console.WriteLine("Invalid goal type!");
                break;
        }
    }

    static void RecordEvent(GoalManager manager)
    {
        if (manager.GoalCount() == 0)
        {
            Console.WriteLine("No goals available to record!");
            return;
        }

        manager.DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        
        if (int.TryParse(Console.ReadLine(), out int goalNum))
        {
            manager.RecordGoal(goalNum - 1);
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}
