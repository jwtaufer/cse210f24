using System.Runtime.CompilerServices;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
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
            Console.WriteLine($"{i}. {goal.GetShortName()}");
            i++;
        }
    }

    private void ListGoalDetails()
    {
        int i = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
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
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
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
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

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
}