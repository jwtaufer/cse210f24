public class BreathingActivity : Activity
{
    public BreathingActivity(int runCount) : base(runCount)
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Clear();
        Console.Write("Get ready");
        ShowEllipsis(3);
        Console.Write("...");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n");
            Console.Write("Breathe in...");
            ShowCountDown(4);

            Console.WriteLine("\n");
            Console.Write("Breathe out...");
            ShowCountDown(5);
        }

        Console.WriteLine();
        DisplayEndingMessage();
    }
}