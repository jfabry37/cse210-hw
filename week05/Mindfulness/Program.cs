using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int duration = 0;
        int continueActivity = 0;

        while (continueActivity != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            continueActivity = int.Parse(Console.ReadLine());

            if (continueActivity == 1)
            {
                string name = "Breathing";
                string description = "This activity will help you relax by walking you through breathing in and out slowly." 
                +"Clear your mind and focus on your breathing."; 
                
                BreathingActivity breathingActivity = new BreathingActivity(name, description, duration);
                breathingActivity.Run();
            }
            else if (continueActivity == 2)
            {
                string name = "Reflecting";
                string description = "This activity will help you reflect on times in your life when you have shown strength and" 
                +"resilience.This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectingActivity reflectingActivity = new ReflectingActivity(name, description, duration);
                reflectingActivity.Run();
            }
            else if (continueActivity == 3)
            {
                string name = "Listing";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity listingActivity = new ListingActivity(name, description, duration);
                listingActivity.Run();
            }
        }

       
    }
}