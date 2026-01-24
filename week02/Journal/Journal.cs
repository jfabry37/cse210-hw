
public class Journal
{

public static List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {   
        PromptGenerator promptGen = new PromptGenerator();
        newEntry._promptText = promptGen.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);
        Console.Write(">");
        newEntry._entryText = Console.ReadLine();
        newEntry._date = DateTime.Now;
        Journal.entries.Add(newEntry);
    }

    public void SaveToFile(string fileName)

    {  
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
            
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }  

    }
    public void LoadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry entry = new Entry();
            entry._date = DateTime.Parse(parts[0]);
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            entries.Add(entry);
        }
    }
}