public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int runCount) : base(runCount)
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        GetListFromUser();
        Console.WriteLine($"\nYou have listed {_count} items.");
        ShowSpinner(6);
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Console.Clear();
        Random prompt = new Random();
        int i = prompt.Next(_prompts.Count);
        Console.WriteLine($"{_prompts[i]}");
        ShowSpinner(6);
    }

    private List<string> GetListFromUser()
    {
        List<string> answers = new List<string>();

        _count = 0;
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            answers.Add(Console.ReadLine());
            _count++;
        }

        return answers;
    }
}