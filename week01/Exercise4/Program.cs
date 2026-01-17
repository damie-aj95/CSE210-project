using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            while (true)
            {
                Console.Write("Enter number: ");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                    break;

                numbers.Add(input);
            }

            // Core Requirements
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Count;
            int largest = numbers[0];

            foreach (int num in numbers)
            {
                if (num > largest)
                    largest = num;
            }

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");

            // Stretch Challenge - Smallest Positive Number
            int smallestPositive = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num > 0 && num < smallestPositive)
                {
                    smallestPositive = num;
                }
            }

            if (smallestPositive == int.MaxValue)
            {
                Console.WriteLine("There is no positive number in the list.");
            }
            else
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            // Stretch Challenge - Sorted List
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
