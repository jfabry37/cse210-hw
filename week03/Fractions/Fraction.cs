using System.Dynamic;

public class Fraction
{
    private int _numerator;
    private int _denominator;

   
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
        Console.WriteLine("Default Fraction created: 1/1");
    }
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
        Console.WriteLine($"Fraction created with numerator: {numerator}/1");
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator; 
        Console.WriteLine($"Fraction created with numerator: {numerator}/{denominator}");
    }

    public string GetFractionString()
    {
       string text= ($"{_numerator}/{_denominator}");
       return text;
    }

    public double GetDecimalValue ()
    {
        
        return (_numerator/_denominator);
    }
}
