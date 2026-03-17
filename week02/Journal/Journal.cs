using System;
using System.Collections.Generic; // Obligatorio para poder usar Listas
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
        foreach(Entry page in _entries)
        {
            page.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry page in _entries)
            {
                outputFile.WriteLine($"{page._date}~|~{page._questionPrompt}~|~{page._userText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {

        _entries.Clear();


        string[] lines = System.IO.File.ReadAllLines(file);


        foreach (string line in lines)
        {

            string[] parts = line.Split("~|~");

            Entry loadedEntry = new Entry();

            loadedEntry._date = parts[0];
            loadedEntry._questionPrompt = parts[1];
            loadedEntry._userText = parts[2];

            _entries.Add(loadedEntry);
        }
    }
}

