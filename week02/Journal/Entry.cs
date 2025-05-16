using System;
using System.Collections.Generic;

public class Entry
{
    public string _promptText;
    public string _entryText;
    public string _date;
    public List<string> _tags = new List<string>();

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        if (_tags.Count > 0)
        {
            Console.WriteLine($"Tags: {string.Join(", ", _tags)}");
        }
        Console.WriteLine();
    }
}