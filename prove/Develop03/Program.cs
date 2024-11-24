//Exceeded core requirements by adding the "Library" class to handle more than one scripture. Had to modify my "Scripture" class because it couldn't properly handle situations in which "numberToHide" was not a perfect multiple of the words that were left to hide. (The Scripture I chose initially just happened to be a perfect multiple. What are the odds?)

using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;

        Library library = new Library();

        Scripture scripture = library.GetRandomScripture();

        while(isRunning)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("(Press 'Enter' to continue, or type 'quit'): ");
            string userInput = Console.ReadLine();

            if(userInput.ToLower() == "q" || userInput.ToLower() == "quit")
            {
                isRunning = false;
            }
            else if(scripture.IsCompletelyHidden())
            {
                isRunning = false;
            }
            else
            {
                scripture.HideRandomWords(4);
            }
        }
    }
}