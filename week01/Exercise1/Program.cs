using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for first name
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();
            
            // Ask for last name
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();
            
            // Display result (Bond-style)
            Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        }
    }
}