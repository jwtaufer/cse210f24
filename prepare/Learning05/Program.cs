using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test1 = new Assignment("Jake", "English");
        Console.WriteLine(test1.GetSummary());

        Console.WriteLine();

        MathAssignment test2 = new MathAssignment("Lis", "Multiplication", "3", "4-20");
        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment test3 = new WritingAssignment("Kip Hartvigsen", "English", "Writing is hell");
        Console.WriteLine(test3.GetSummary());
        Console.WriteLine(test3.GetWritingInformation());
    }
}