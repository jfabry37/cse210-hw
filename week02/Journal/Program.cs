using System;
using System.Collections.Generic;
using System.IO;


class Program
{   
    static void Main(string[] args)
    {   string choice = "";
        Journal newJournal = new Journal();
      

        while (choice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();


            if (choice == "1")
            {
                // Write
                newJournal.AddEntry(new Entry());
            }
            else if (choice == "2")
            {
                // Display
                Entry entry = new Entry();
                entry.DisplayEntry();
            }
            else if (choice == "3")
            {
                // Load
                Console.Write("Enter the filename to load: ");
                string fileName = Console.ReadLine();
                newJournal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                // Save
                Console.Write("Enter the filename to save: ");
                string fileName = Console.ReadLine();
                newJournal.SaveToFile(fileName);
            }
            
        }
    }
}