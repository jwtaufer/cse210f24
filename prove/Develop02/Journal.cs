using System.IO;
using System.Net;

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
        Console.Write("Would you like to save? (Y/N): ");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
        {    
            using (StreamWriter file = new StreamWriter("journal.txt"))
            {
                foreach (Entry entry in _entries)
                {
                    file.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
                }
            }
        }
    }

    public void LoadJournal()
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines("journal.txt");

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
        catch {}
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