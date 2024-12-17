using System;

class Program
{
    static void Main(string[] args)
    {
        string date = DateTime.Now.ToString("dd MMM yyyy");
        int minutes = 30;
        int distance = 2;
        int speed = 20;
        int laps = 48;
        
        List<Activity> activities = new List<Activity>();

        Activity running = new Running(date, minutes, distance);
        activities.Add(running);

        Activity cycling = new Cycling(date, minutes, speed);
        activities.Add(cycling);

        Activity swimming = new Swimming(date, minutes, laps);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}