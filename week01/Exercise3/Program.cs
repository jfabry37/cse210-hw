using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // used for steps 1-2 where the user inputs th number.
        //Console.Write("What is the magic number? ");
        //string Input = Console.ReadLine();
        //int Number = int.Parse(Input);
        //int Guess = -1;
        String PlayAgain = "yes";
        while (PlayAgain == "yes")
        {
            Random randomGenerator = new Random();
            int Number = randomGenerator.Next(1,50);
            int Guess = -1;
            int NumberOfGuesses = 1;
            while (Guess != Number)
            {
                Console.Write("What is your guess? ");
                Guess = int.Parse(Console.ReadLine());

                if (Guess < Number)
                {
                    Console.WriteLine("Higher");
                }
                if (Guess > Number)
                {
                    Console.WriteLine("Lower");
                }
                else if (Guess == Number)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {NumberOfGuesses} guesses to find the number {Number}.");
                }
                NumberOfGuesses += 1;
            }

            Console.Write("Would You like to play again? (yes or no)" );
            PlayAgain = Console.ReadLine();
        }
    }   
}