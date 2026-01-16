public class Entry
{
    public string _date;
    public string _promtText;

    public string _entryText;

    public void DisplayEntry(Journal newJournal)
    {        
        DateTime theCurrentTime= DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
            for (int i = 0; i < newJournal.promtList.Count; i++)
            {
                string _promtText = newJournal.promtList[i];

                Console.WriteLine($"Date: {_date} - {_promtText}:");  
                Console.WriteLine(newJournal._entries[i]);
            }
         
    }
}