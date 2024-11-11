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

    // public void Display()
    // {
    //     Console.WriteLine($"Company: {_company}\nJob title: {_jobTitle}\nStart Year: {_startYear}\nEnd Year: {_endYear}");
    // }
}