using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {

    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs) //sample solution used: foreach (Job job in _jobs)
        {
            Console.Write("    ");
            job.Display();
        }
    }
}

//Sample solution: https://github.com/byui-cse/cse210-ww-student-sample-solutions/tree/main/prepare/Learning02/Resume.cs