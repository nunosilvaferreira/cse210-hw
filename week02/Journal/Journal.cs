using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void DisplayByTag(string tag)
    {
        Console.WriteLine($"\nEntries with tag '{tag}':");
        foreach (Entry entry in _entries)
        {
            if (entry._tags.Contains(tag))
            {
                entry.Display();
            }
        }
    }

    public List<string> GetAllTags()
    {
        List<string> allTags = new List<string>();
        foreach (Entry entry in _entries)
        {
            foreach (string tag in entry._tags)
            {
                if (!allTags.Contains(tag))
                {
                    allTags.Add(tag);
                }
            }
        }
        return allTags;
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string tagsString = string.Join(",", entry._tags);
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{tagsString}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            
            Entry loadedEntry = new Entry();
            loadedEntry._date = parts[0];
            loadedEntry._promptText = parts[1];
            loadedEntry._entryText = parts[2];
            
            if (parts.Length > 3 && !string.IsNullOrEmpty(parts[3]))
            {
                string[] tags = parts[3].Split(',');
                loadedEntry._tags.AddRange(tags);
            }
            
            _entries.Add(loadedEntry);
        }
    }
}