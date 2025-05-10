using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            
            List<int> numbers = new List<int>();
            int number;
            
            // Collect numbers from user
            do
            {
                Console.Write("Enter number: ");
                string input = Console.ReadLine();
                
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }
                
                if (number != 0)
                {
                    numbers.Add(number);
                }
                
            } while (number != 0);

            // Core Requirement 1: Compute sum
            int sum = numbers.Sum();
            Console.WriteLine($"The sum is: {sum}");

            // Core Requirement 2: Compute average
            double average = numbers.Average();
            Console.WriteLine($"The average is: {average}");

            // Core Requirement 3: Find maximum
            int max = numbers.Max();
            Console.WriteLine($"The largest number is: {max}");

            // Stretch Challenge 1: Find smallest positive number
            if (numbers.Any(n => n > 0))
            {
                int smallestPositive = numbers.Where(n => n > 0).Min();
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            // Stretch Challenge 2: Sort and display list
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}