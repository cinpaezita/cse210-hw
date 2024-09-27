using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }


    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        using(StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2],
                    };
                    AddEntry(entry);
                }   
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    //This is the first version without handling the error
    //of loading a non-existen file.
    //public void LoadFromFile(string fileName)
    //{
    //   string[] lines = System.IO.File.ReadAllLines(fileName);
    //        foreach(string line in lines)
    //        {
    //            string[] parts = line.Split('|');

    //            Entry entry = new Entry
    //            {
    //                _date = parts[0],
    //                _promptText = parts[1],
    //               _entryText = parts[2],
    //            };
                
    //            AddEntry(entry);
    //        }
    //}
        
}