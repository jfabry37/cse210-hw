using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int total = 0;
        double Count = 0;
        int max = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int InputNumber = int.Parse(Console.ReadLine());
        while (InputNumber != 0)
        {

            numbers.Add(InputNumber);
            Console.Write("Enter number: ");
            InputNumber = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(string.Join(", ", numbers));
        
        foreach (int number in numbers)
        {
          total += number;
          if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum is: {total}");
        Count = numbers.Count;
        Count = total / Count;
        Console.WriteLine($"The average is: {Count}");
        Console.WriteLine($"The largest number is: {max}");

    }
}