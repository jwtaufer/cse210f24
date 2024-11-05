using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int percentage = int.Parse(userInput);

        if (percentage >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("Grade: B");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("Grade: C");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("Grade: D");
        }
        else if (percentage < 60)
        {
            Console.WriteLine("Grade: F");
        }
    }
}