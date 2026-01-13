using System;

class Program
{
    static void Main(string[] args)

    {
        DisplayWelcome();
        string name = PropmtUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);

        static void DisplayWelcome()
        {
            Console.WriteLine("welcome to the Program!");
        }
        static string PropmtUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            return int.Parse(number);
        }
        static int SquareNumber(int number)
        {
            double square = number * number;
            return (int)square;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

    }
}