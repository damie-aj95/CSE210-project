using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "List positive things in your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        int count = 0;

        DateTime end = DateTime.Now.AddSeconds(_timer);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        DisplayEndingMessage();
    }
}
