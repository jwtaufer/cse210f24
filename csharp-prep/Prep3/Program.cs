using System;
using System.Data;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain == true)
        {
            Random randomGenerator = new Random();
            int magicNumber =  randomGenerator.Next(1, 101);
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
                    Console.WriteLine($"Guesses: {guesses}");
                }

                guesses++;
            } while (guess != magicNumber);

            Console.Write("Would you like to play again? ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }
    }
}