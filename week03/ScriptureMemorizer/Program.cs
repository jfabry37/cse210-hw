using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Reference newReference = new Reference ("Proverbs",3,5,6);
        string text = "Trust in the Lord with all thine heart and lean not unto your own"
        +"understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture newScripture = new Scripture(newReference , text);
        string userKey = " ";
        Random random = new Random();
        bool done = false;
    
        while (userKey != "quit" && done == false)
        {
            Console.Clear();
            Console.WriteLine(newScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            done = newScripture.IsCompletelyHidden();
            if (!newScripture.IsCompletelyHidden())
            {
                userKey = "quit";
            }
            int wordsToHide = random.Next(1,4);
            newScripture.HideRandomWords(wordsToHide);
            userKey = Console.ReadLine()?.ToLower();   
        }
    }
}