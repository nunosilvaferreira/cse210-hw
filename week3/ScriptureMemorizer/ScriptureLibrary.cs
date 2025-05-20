using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();
    private Random _random = new Random();

    public void LoadScripturesFromFile(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length >= 3)
                {
                    string reference = parts[0].Trim();
                    string text = parts[1].Trim();

                    Reference refObj = ParseReference(reference);
                    _scriptures.Add(new Scripture(refObj, text));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scriptures: {ex.Message}");
            // Load default scriptures if file fails
            LoadDefaultScriptures();
        }
    }

    private Reference ParseReference(string reference)
    {
        string[] parts = reference.Split(' ');
        string book = parts[0];
        string[] chapterVerse = parts[1].Split(':');
        int chapter = int.Parse(chapterVerse[0]);

        if (chapterVerse[1].Contains('-'))
        {
            string[] verses = chapterVerse[1].Split('-');
            int startVerse = int.Parse(verses[0]);
            int endVerse = int.Parse(verses[1]);
            return new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            int verse = int.Parse(chapterVerse[1]);
            return new Reference(book, chapter, verse);
        }
    }

    private void LoadDefaultScriptures()
    {
        _scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        ));

        _scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."
        ));
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
            LoadDefaultScriptures();

        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}