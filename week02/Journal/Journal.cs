
public class Journal
{

public List<string> _entries = new List<string>();
public List<string> promtList = new List<string>();

    public void AddEntry(Entry newEntry)
    {   
        PromtGenerator promptGen = new PromtGenerator();
        promptGen.GetRandomPrompt();
        string promts = promptGen.GetRandomPrompt();
        Console.WriteLine(promts);
        promtList.Add(promts);
        newEntry._entryText = Console.ReadLine();
        _entries.Add(newEntry._entryText);
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
        foreach (string entry in _entries)
        {
            for (int i = 0; i < promtList.Count; i++)
            {
                string _promtText = promtList[i];
            //    Console.WriteLine($"Date: {newEntry._date} - {_promtText}:");  
                Console.WriteLine(entry);
            }
        }
        }
    }
    public void LoadFromFile(string fileName)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            _entries.Add(line);
        }
    }
}

       // foreach (string entry in newJournal._entries)
      //  {
    //        for (int i = 0; i < newJournal.promtList.Count; i++)
          //  {
        //        string _promtText = newJournal.promtList[i];

      //          string line1 = ($"Date: {_date} - {_promtText}:");  
               // string line2 = (entry);
             //   outputlist.Add(line1);
           //     outputlist.Add(line2);