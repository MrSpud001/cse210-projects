using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fractionClass1 = new Fraction(8,10);

        Console.WriteLine($"{fractionClass1.GetFractionString()}");
        Console.WriteLine($"{fractionClass1.GetDecimalValue()}");

        Fraction fractionClass2 = new Fraction(5,20);

        Console.WriteLine($"{fractionClass2.GetFractionString()}");
        Console.WriteLine($"{fractionClass2.GetDecimalValue()}");

        Fraction fractionClass3 = new Fraction(27,30);

        Console.WriteLine($"{fractionClass3.GetFractionString()}");
        Console.WriteLine($"{fractionClass3.GetDecimalValue()}");
    }
}