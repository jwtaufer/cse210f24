using System.Reflection;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected int _runCount;

    protected Activity(int runCount)
    {
        _runCount = runCount;
    }

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected void DisplayEndingMessage()
    {
        Console.Clear();
        _runCount++;
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}. You've completed {_runCount} activities.");
        ShowSpinner(6);
    }

    protected void ShowEllipsis(int seconds)
    {
        for (int i = seconds / 3; i > 0; i--)
        {
            for (int j = 3; j > 0; j--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.Write("\b\b\b   \b\b\b");
        }
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> animations = ["\\", "|", "/", "-"];
        
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        
        while (DateTime.Now < endTime)
        {
            foreach (string animation in animations)
            {
                Console.Write(animation);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i > 999)
            {
                Console.Write("\b\b\b\b    \b\b\b\b");
            }
            else if (i > 99)
            {
                Console.Write("\b\b\b   \b\b\b");
            }
            else if (i > 9)
            {
                Console.Write("\b\b  \b\b");
            }
            else
            {
                Console.Write("\b \b");
            }
        }
    }
}