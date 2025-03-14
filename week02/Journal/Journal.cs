using System.IO;

public class Journal{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        foreach (Entry entry in _entries){
            entry.Display();
        }
    }

    public void SaveToFile(string file){
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries){
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entry}");
            }
        }
    }

    public void LoadFromFile(string file){
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines){
            string[] parts = line.Split(",");
            Entry load = new Entry();
            load._date = parts[0];
            load._promptText = parts[1];
            load._entry = parts[2];
            load.Display();
        }
    }
}