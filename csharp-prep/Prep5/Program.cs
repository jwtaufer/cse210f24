using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        double squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static double SquareNumber(int number)
    {
        double squareNumber = Math.Pow(number,2);
        return squareNumber;
    }

    static void DisplayResult(string name, double squareNumber)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {squareNumber}");
    }

}