using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction();
        Fraction test2 = new Fraction(6);
        Fraction test3 = new Fraction(6/7);

        Fraction test4 = new Fraction();
        test4.SetTop(12);
        test4.SetBottom(11);
        Console.WriteLine(test4.GetTop());
        Console.WriteLine(test4.GetBottom());
    }
}