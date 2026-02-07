using System.Data;

class Activity
{
 protected string _name;
 protected string _description;
 protected int _duration;
/// if we  keep member varibles private use getters and setter to access them.
///  or change the access modifier to protected to allow access in derived classes.///
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
       
    }
   

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the " + _name + " Activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? " );
         int duration = int.Parse(Console.ReadLine());
        SetDuration(duration); 
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowAnimation(2);
        Console.WriteLine();       
    
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done! !");
        ShowAnimation(5);
        Console.WriteLine("\nYou have completed another " + _duration + " seconds of the " + _name +" Activity.");
        ShowAnimation(5);
        Console.Clear();
    }

    public void ShowAnimation(int seconds)
    {
        List<string> animationFrames = new List<string> {};
        animationFrames.Add("|");
        animationFrames.Add("/");
        animationFrames.Add("-");
        animationFrames.Add("\\");
        animationFrames.Add("|");
        animationFrames.Add("/");
        animationFrames.Add("-");
        animationFrames.Add("\\");

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);
    int i = 0;
         while (DateTime.Now < endTime)
        {
            string frame = animationFrames[i];
            Console.Write(frame);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animationFrames.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}