using System.IO; 
public class Journal
{
    public List<Entry> _entries = [];


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");

            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
             foreach (Entry entry in _entries)
            {
            outputFile.WriteLine($"{entry._date},{entry._entryText},{entry._promptText}");
                
            }
        }
    }
    public void LoadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry loadedEntry = new Entry();

            string[] parts = line.Split(",");

            string loadedDate = parts[0];
            string loadedEntryText = parts[1];
            string loadedPromptText = parts[2];


            loadedEntry._date = loadedDate;
            loadedEntry._entryText = loadedEntryText;
            loadedEntry._promptText = loadedPromptText;

            AddEntry(loadedEntry);
        }
    }


}