using System;
using System.Runtime.CompilerServices;
using System.IO;
using System.Collections;
using System.Net;
using System.Formats.Asn1;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private List<string> _files;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _files = new List<string>();
    }

    public void Start()
    {
        bool programRunning = true;

        while(programRunning)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Goals");
            Console.WriteLine("    6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    programRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Enter a number from the menu (e.g. '1') and hit 'Enter'.");
                    break;
            }
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    private void ListGoalsNames()
    {
        int i = 1;

        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"    {i}. {goal.GetShortName()}");
            i++;
        }
    }

    private void ListGoalDetails()
    {
        int i = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"    {i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        
        Console.Write("Which type of goal would you like to create? ");
        string userInput = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        Goal goal;

        switch(userInput)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(goal);
                break;
            default:
                Console.WriteLine("Invalid input. Enter a number from the menu (e.g. '1') and hit 'Enter'.");
                break;
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalsNames();
        Console.Write("Which goal did you accomplish? ");
        string userInput = Console.ReadLine();

        int i = int.Parse(userInput) - 1;

        _goals[i].RecordEvent();
        _score += _goals[i].GetPoints();
    }

    private void SaveGoals()
    {
        Console.WriteLine("Saved files: ");
        ShowFiles();
        int cancel = _files.Count() + 1;

        Console.WriteLine($"    {cancel}. Cancel");
        
        Console.Write("Select a file to save to over, or enter a new filename: ");
        string userInput = Console.ReadLine();

        string filename;
        if (Char.IsNumber(userInput, 0))
        {
            if (int.Parse(userInput) == cancel)
            {
                return;
            }
            else
            {
                filename = _files[int.Parse(userInput) - 1];
            }
        }
        else
        {
            filename = userInput;
        }

        using (StreamWriter outputFile = new StreamWriter($"saves/{filename}"))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.WriteLine("Loadable files: ");
        ShowFiles();
        int cancel = _files.Count() + 1;
        Console.WriteLine($"    {cancel}. Cancel");
        
        Console.Write("Select a file:  ");
        int userInput = int.Parse(Console.ReadLine());

        if (userInput == cancel)
        {
            return;
        }
        else
        {
            _goals.Clear();
            _score = 0;
        }

        int i = userInput - 1;

        string[] lines = System.IO.File.ReadAllLines($"saves/{_files[i]}");

        foreach (string line in lines)
        {
            Goal goal;
            string[] parts = line.Split("|");

            if (parts[0] == "SimpleGoal")
            {
                goal = new SimpleGoal(parts[1], parts[2], parts[3], bool.Parse(parts[4]));
                _goals.Add(goal);
            }
            else if (parts[0] == "EternalGoal")
            {
                goal = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(goal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                goal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[4]));
                _goals.Add(goal);
            }
            else
            {
                _score = int.Parse(parts[0]);
            }
        }
    }

    private void ShowFiles()
    {
        int i = 1;

        _files.Clear();

        string[] files = Directory.GetFiles("saves/", "*txt");

        foreach (string file in files)
        {
            string[] parts = file.Split("/");

            _files.Add(parts[1]);
            Console.WriteLine($"    {i}. {parts[1]}");
            i++;
        }
    }
}