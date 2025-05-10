using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize random number generator
            Random randomGenerator = new Random();
            
            string playAgain = "yes";
            
            // Stretch Challenge 2: Outer loop for playing multiple games
            while (playAgain == "yes")
            {
                // Core Requirement 3: Generate random magic number
                int magicNumber = randomGenerator.Next(1, 101);
                int guessCount = 0; // Stretch Challenge 1: Track number of guesses
                
                Console.WriteLine("Welcome to Guess My Number Game!");
                Console.WriteLine("I've picked a number between 1 and 100.");
                
                int guess = 0;
                
                // Core Requirement 2: Loop until correct guess
                while (guess != magicNumber)
                {
                    Console.Write("What is your guess? ");
                    string input = Console.ReadLine();
                    
                    // Validate input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Please enter a valid number.");
                        continue;
                    }
                    
                    guessCount++; // Increment guess counter
                    
                    // Core Requirement 1: Check guess against magic number
                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        
                        // Stretch Challenge 1: Show guess count
                        Console.WriteLine($"It took you {guessCount} guesses.");
                    }
                }
                
                // Stretch Challenge 2: Ask to play again
                Console.Write("Would you like to play again? (yes/no) ");
                playAgain = Console.ReadLine().ToLower();
            }
            
            Console.WriteLine("Thanks for playing! Goodbye.");
        }
    }
}