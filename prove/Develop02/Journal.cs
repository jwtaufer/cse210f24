public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private Entry entry = new Entry();
    private Prompt prompt = new Prompt();

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry._date);
        }

        Console.Write("(Press 'Enter' to close display.)");
        Console.ReadLine();
    }

    public void SaveJournal()
    {

    }

    // public string LoadJournal()
    // {

    // }

    public void AddEntry()
    {        
        entry._date = DateTime.Now.ToShortDateString();
        Console.WriteLine(entry._date);

        entry._prompt = prompt.GeneratePrompt();
        Console.WriteLine(entry._prompt);

        Console.Write("Input: ");
        entry._entry = Console.ReadLine();
    }
}