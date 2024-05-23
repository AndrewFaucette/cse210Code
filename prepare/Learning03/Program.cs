using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
        Fraction two = new Fraction(6);
        Console.WriteLine(two.GetFractionString());
        Console.WriteLine(two.GetDecimalValue());
        Fraction three = new Fraction(6,7);
        Console.WriteLine(three.GetFractionString());
        Console.WriteLine(three.GetDecimalValue());
    }
}