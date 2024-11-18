using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry._date);
            Console.WriteLine(entry._prompt);
            Console.WriteLine(entry._entry);
            Console.WriteLine();
        }

        Console.Write("(Press 'Enter' to close display.)");
        Console.ReadLine();
    }

    public void SaveJournal()
    {
        Console.Write("Enter file name (e.g. filename.txt): ");
        string fileName = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                file.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
            }
        }
    }

    public void LoadJournal()
    {
        Console.Write("Enter the name of the file you'd like to load (e.g. filename.txt): ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts [2];

            _entries.Add(entry);
        }
    }

    public void AddEntry()
    {        
        Entry entry = new Entry();
        Prompt prompt = new Prompt();

        entry._date = DateTime.Now.ToShortDateString();
        Console.WriteLine(entry._date);

        entry._prompt = prompt.GeneratePrompt();
        Console.WriteLine(entry._prompt);

        Console.Write("Input: ");
        entry._entry = Console.ReadLine();

        _entries.Add(entry);
    }
}