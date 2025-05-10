using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call all functions in sequence
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber);
            DisplayResult(userName, squaredNumber);
        }

        // Displays welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // Prompts for and returns user's name
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        // Prompts for and returns user's favorite number
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            
            // Validate input is a number
            while (!int.TryParse(input, out int number))
            {
                Console.Write("Please enter a valid number: ");
                input = Console.ReadLine();
            }
            
            return int.Parse(input);
        }

        // Squares the given number and returns result
        static int SquareNumber(int number)
        {
            return number * number;
        }

        // Displays the final result
        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        }
    }
}