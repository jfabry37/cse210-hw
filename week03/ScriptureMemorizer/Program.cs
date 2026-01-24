using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
class Program
{
    static void Main(string[] args)
    {
        Reference newReference = new Reference ("mom", 5,2,6);
        string text = "The day will come when all will change so enjoy today";
        Scripture newScripture = new Scripture(newReference , text);
        string userKey = " ";
        Random random = new Random();
        bool done = false;
        //!newScripture.IsCompletelyHidden()
        while (userKey != "quit" && done == false)
        {
            Console.Clear();
            Console.WriteLine(newScripture.GetDisplayText());
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