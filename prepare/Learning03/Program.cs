using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionOne = new Fraction();
        Fraction fractionTwo = new Fraction(5);
        Fraction fractionThree = new Fraction(3, 4);
        Fraction fractionFour = new Fraction(1, 3);
        Fraction[] fractions = [fractionOne, fractionTwo, fractionThree, fractionFour];
        foreach(Fraction fr in fractions)
        {
            Console.WriteLine(fr.GetFractionString());
            Console.WriteLine(fr.GetDecimalValue());
        }
    }
}