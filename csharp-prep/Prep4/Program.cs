using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        int number = -1;

        List<int> numbers = new List<int>();

        int sum = 0;
        int max = 0;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
            sum += number;
            
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(float)sum / numbers.Count}");
        Console.WriteLine($"The largest number is: {max}");
    }
}