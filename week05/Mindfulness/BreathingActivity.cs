// using System.Diagnostics;

class BreathingActivity: Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
         
    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Thread.Sleep(1000);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write(" Breathe in...");
            ShowCountDown(4);
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.Write(" Breathe out...");
            ShowCountDown(5);
            Thread.Sleep(1000);
            Console.WriteLine();
            
        }
        Console.WriteLine();
        DisplayEndingMessage();

    }


}