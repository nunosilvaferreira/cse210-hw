using System;
using System.Collections.Generic;

/*
Exceeding Requirements:
1. Added a ScriptureLibrary class to manage multiple scriptures that can be randomly selected.
2. Implemented a smarter word hiding algorithm that prioritizes unhidden words.
3. Added the ability to show hidden words if the user types "show" (for when they need help).
4. Added color coding to make hidden words stand out.
5. Added error handling for file operations when loading scriptures.
*/

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        library.LoadScripturesFromFile("scriptures.txt");
        
        Scripture scripture = library.GetRandomScripture();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words, type 'show' to reveal words, or 'quit' to exit:");
            
            string input = Console.ReadLine().ToLower();
            
            if (input == "quit")
                break;
                
            if (input == "show")
            {
                scripture.ShowAllWords();
                continue;
            }
            
            if (scripture.IsCompletelyHidden())
                break;
                
            scripture.HideRandomWords(3);
        }
    }
}