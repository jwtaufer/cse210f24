// I've exceeded expectations by keeping a log of how many times an activity is performed, and that log is displayed in the DisplayEndingMessage() method in the Activity class.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool programRunning = true;
        int runCount = 0;

        while (programRunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine($"    1. Breathing Activity");
            Console.WriteLine($"    2. Reflecting Activity");
            Console.WriteLine($"    3. Listing Activity");
            Console.WriteLine($"    4. Quit");
            Console.Write("Select an activity: ");
            int userInput = int.Parse(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity(runCount);
                    breathingActivity.Run();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity(runCount);
                    reflectingActivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity(runCount);
                    listingActivity.Run();
                    break;
                case 4:
                    programRunning = false;
                    Console.Clear();
                    break;
            }
            runCount++;
        }
    }
}