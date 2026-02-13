using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();   
        Activity running = new Running(DateTime.Now, 30, 3);
        activities.Add(running);
        Activity cycling = new Cycling(DateTime.Now, 60, 25);
        activities.Add(cycling);
        Activity swimming = new Swimming(DateTime.Now, 30, 20);
        activities.Add(swimming);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}