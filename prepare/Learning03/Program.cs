using System;

class Program
{
    static void Main(string[] args)
    {
        // //Step 4
        // Fraction test1 = new Fraction();
        // Fraction test2 = new Fraction(6);
        // Fraction test3 = new Fraction(6/7);

        // //Step 5
        // Fraction test4 = new Fraction();
        // test4.SetTop(25);
        // test4.SetBottom(10);
        // Console.WriteLine(test4.GetTop());
        // Console.WriteLine(test4.GetBottom());

        // //Step 6
        // Console.WriteLine(test4.GetFractionString());
        // Console.WriteLine(test4.GetDecimalValue());

        Fraction test5 = new Fraction(1);
        Console.WriteLine(test5.GetFractionString());
        Console.WriteLine(test5.GetDecimalValue());

        Fraction test6 = new Fraction(5);
        Console.WriteLine(test6.GetFractionString());
        Console.WriteLine(test6.GetDecimalValue());

        Fraction test7 = new Fraction(3, 4);
        Console.WriteLine(test7.GetFractionString());
        Console.WriteLine(test7.GetDecimalValue());

        Fraction test8 = new Fraction(1, 3);
        Console.WriteLine(test8.GetFractionString());
        Console.WriteLine(test5.GetDecimalValue());
    }
}