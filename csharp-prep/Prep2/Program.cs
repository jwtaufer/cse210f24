using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int percentage = int.Parse(userInput);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else if (percentage < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Grade: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You are passing.");
        }
        else
        {
            Console.WriteLine("Sorry, but you need at least a 'C' to pass this class. Better luck next semester.");
        }

        Console.ReadLine();
        Console.Clear();
    }
}