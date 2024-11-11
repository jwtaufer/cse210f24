using System;
using System.ComponentModel.DataAnnotations;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job()
    {

    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

//Sample solution: https://github.com/byui-cse/cse210-ww-student-sample-solutions/tree/main/prepare/Learning02/Job.cs