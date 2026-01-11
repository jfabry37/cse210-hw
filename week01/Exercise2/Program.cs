using System;

class Program
{
    static void Main(string[] args)
    {   

        Console.Write("What is your grade percentage? ");
        string Percentage = Console.ReadLine();
        int GradePercentage = int.Parse(Percentage); 
        string Letter;
        if (GradePercentage >= 90)
        {
            Letter = "A";
        }
        else if (GradePercentage <= 89 && GradePercentage>= 80)
        {
            Letter = "B";
        }
        else if (GradePercentage <=79 && GradePercentage >=70)
        {
            Letter = "C";
        }
        else if (GradePercentage <= 69 && GradePercentage >= 60)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }
        Console.WriteLine($"Your grade is: {Letter}");
        if (GradePercentage >= 70)
        {
            Console.WriteLine("Congratulations you pass!");
        }
        else
        {
            Console.WriteLine($"You did not pass, better luck next time!");
        }

    }

}