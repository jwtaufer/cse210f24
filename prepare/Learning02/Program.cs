using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Rosewood Painting";
        job1._jobTitle = "Painter";
        job1._startYear = 2017;
        job1._endYear = 2023;
        // job1.Display();
        Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._company = "Schilders LLC";
        job2._jobTitle = "Owner";
        job2._startYear = 2024;
        job2._endYear = 2124;
        // job2.Display();
        Console.WriteLine(job1._company);
    }
}