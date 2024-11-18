using System;

class Program
{
    static void Main(string[] args)
    {
        bool programRunning = true;
        Journal journal = new Journal();

        while (programRunning)
        {                
            Console.Clear();
            Console.WriteLine("Select one of the following: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

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
                case 3: //Load
                    Console.Clear();
                    journal.LoadJournal();
                    break;
                case 4: //Save
                    Console.Clear();
                    journal.SaveJournal();
                    break;
                case 5: //Quit
                    programRunning = false;
                    Console.Clear();
                    break;
            }

            Console.WriteLine();
        }
    }
}