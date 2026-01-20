using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fractionRun1 = new Fraction();
        Console.WriteLine(fractionRun1.GetDecimalValue());
        Console.WriteLine(fractionRun1.GetFractionString());


        Fraction fractionRun2 = new Fraction(5);
        Console.WriteLine(fractionRun2.GetDecimalValue());
        Console.WriteLine(fractionRun2.GetFractionString());


        Fraction fractionRun3 = new Fraction(3, 4);
        Console.WriteLine(fractionRun3.GetDecimalValue());
        Console.WriteLine(fractionRun3.GetFractionString());
    
    }

}