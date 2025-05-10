using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Core Requirement 1: Ask for grade percentage
            Console.Write("Enter your grade percentage: ");
            string userInput = Console.ReadLine();
            int gradePercentage = int.Parse(userInput);

            string letter = ""; // Variable to store letter grade (Core Requirement 3)
            string sign = "";   // Variable for stretch challenge (sign)

            // Core Requirement 1 & 3: Determine letter grade
            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
            }
            else if (gradePercentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            // Stretch Challenge 1: Determine sign
            if (gradePercentage >= 60 && gradePercentage < 97 && letter != "F")
            {
                int lastDigit = gradePercentage % 10;
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }

            // Stretch Challenge 2: Handle A+ exception (no A+)
            if (letter == "A" && sign == "+")
            {
                sign = ""; // Remove sign for A
            }

            // Stretch Challenge 3: Handle F exceptions (no F+ or F-)
            if (letter == "F")
            {
                sign = ""; // Remove sign for F
            }

            // Core Requirement 3: Print letter grade
            Console.WriteLine($"Your letter grade is: {letter}{sign}");

            // Core Requirement 2: Check if passed
            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Don't worry, you can try again next time!");
            }
        }
    }
}