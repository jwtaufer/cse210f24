//I showed creativity and exceeded requirements by simplifying the main menu. To me, it was clunky. I'd rather have my journal automatically load, lest I forget to do it myself. I'd also likely forget to save before quitting. My solution for this was to modify the SaveJournal() function, then call it when the user chooses to quit. With these changes the user doesn't have to worry about typing in the right file name when they load or save, or loading their existing journal before they enter an entry.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool programRunning = true;
        Journal journal = new Journal();

        journal.LoadJournal();

        while (programRunning)
        {                
            Console.Clear();
            Console.WriteLine("Select one of the following: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Quit");

            Console.Write("Input: ");
            int userInput = int.Parse(Console.ReadLine());
            
            switch (userInput)
            {
                case 1: //Write
                    Console.Clear();
                    journal.AddEntry();
                    break;
                case 2: //Display
                    Console.Clear();
                    journal.DisplayJournal();
                    break;
                case 3: //Quit
                    journal.SaveJournal();
                    programRunning = false;
                    Console.Clear();
                    break;
            }
        }
    }
}