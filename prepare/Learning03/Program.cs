using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction defaultFraction = new Fraction();
        Fraction singleValueFraction = new Fraction(5);
        Fraction doubleValueFraction = new Fraction(3, 4);

        Console.WriteLine(defaultFraction.GetFractionString());
        Console.WriteLine(defaultFraction.GetDecimalValue());

        Console.WriteLine(singleValueFraction.GetFractionString());
        Console.WriteLine(singleValueFraction.GetDecimalValue());

        Console.WriteLine(doubleValueFraction.GetFractionString());
        Console.WriteLine(doubleValueFraction.GetDecimalValue());

        doubleValueFraction.Numerator = 1;
        doubleValueFraction.Denominator = 3;

        Console.WriteLine(doubleValueFraction.GetFractionString());
        Console.WriteLine(doubleValueFraction.GetDecimalValue());
    }
}
