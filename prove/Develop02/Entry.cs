public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;

    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_entry);
    }
}