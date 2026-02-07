using System.Runtime.CompilerServices;

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration) : base (name, description, duration)
    {
        _prompts =  new List<string>()
         {
            "Think of a time when you were kind to someone else.",
             "Think of a time when you accomplished something really hard.",
             "Think of a time when you helped someone in need.",
             "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?"
        };
    }
     Random _random = new Random();
    public void Run ()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration); 
        
        Thread.Sleep(1000);
        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
       
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write($"You may begin in :");ShowCountDown(5);
        Console.Clear();
        while (DateTime.Now < endTime)           
         {  
            
            DisplayQuestion(); 
            Thread.Sleep(1000);
            Console.WriteLine();
            
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
            return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");

    }

    public void DisplayQuestion()
    {

        Console.Write($">{GetRandomQuestion()}");ShowAnimation(10);

    }
}