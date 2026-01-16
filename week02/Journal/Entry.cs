public class Entry
{
    public DateTime _date;
    public string _promptText;

    public string _entryText;

    public void DisplayEntry()
    {   
        for (int i = 0; i < Journal.entries.Count; i++)
        {
            Entry entry = Journal.entries[i];
            Console.WriteLine($"Date: {entry._date} - {entry._promptText}");  
            Console.WriteLine(entry._entryText);
        }

    }
}   