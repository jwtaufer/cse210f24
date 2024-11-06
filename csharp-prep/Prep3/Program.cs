using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber =  randomGenerator.Next(1, 100);
        int guess;
        int guesses = 0;

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            guesses++;
            Console.WriteLine(guesses);
        } while (guess != magicNumber);
    }
}