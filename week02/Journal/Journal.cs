using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();

    public void DisplayEntries()
    {
        foreach (Entry entry in Entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine($"Mood: {entry.Mood}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in Entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}|{entry.Mood}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry entry = new Entry();
            entry.Date = parts[0];
            entry.Prompt = parts[1];
            entry.Response = parts[2];
            entry.Mood = parts[3];
            Entries.Add(entry);
        }
    }
}    
