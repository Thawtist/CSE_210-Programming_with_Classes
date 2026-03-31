using System.Security.Cryptography.X509Certificates;
using System;
using System.IO;
using System.Formats.Asn1;
using System.Threading.Tasks.Dataflow;

class Goals
{
    private List<Goal> _goals;

    private string _filename;

    private int _totalScore;

    private void ObtainFileName(string promptString)
    {
        Console.Write($"{promptString}");
        _filename = Console.ReadLine();
    }

    public Goals()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }















    public void LoadGoals()
    {
        ObtainFileName("Please enter the name of the file you would like to load: ");
        if (File.Exists(_filename))
        {
            string[] lines = File.ReadAllLines(_filename);
            foreach (string line in lines)
            {
                string[] items = line.Split('#');
                string goalType = items[0];

                if (goalType == "Score")
                {
                    _totalScore = int.Parse(items[1]);
                }
                else // TODO Process the three goal types here.
                {
                    // All goals have the same first four items
                    string name = items[1];
                    string description = items[2];
                    int points = int.Parse(items[3]);
                    bool status = bool.Parse(items[4]);

                    // Process goal specific logic here.
                    if (goalType == "SimpleGoal")
                    {
                        SimpleGoal smg = new SimpleGoal(name, description, points, status);
                        this.AddGoal(smg);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        int completions = int.Parse(items[5]);
                        EternalGoal etg = new EternalGoal(name, description, points, status, completions);
                        this.AddGoal(etg);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        int completions = int.Parse(items[5]);
                        int maxGoal = int.Parse(items[6]);
                        int bonusPoints = int.Parse(items[7]);
                        CheckListGoal clg = new CheckListGoal(name, description, points, status, completions, maxGoal, bonusPoints);
                        this.AddGoal(clg);
                    }
                }
            }
        }
    }
    public void SaveGoals()
    {
        ObtainFileName("Please enter the name of the file you would like to save: ");
        StreamWriter writer = new StreamWriter(_filename);

        writer.WriteLine($"Score#{_totalScore}");
        foreach (Goal goal in _goals)
        {
            writer.Write($"{goal.GetFileSystemString()}\n");
        }
        writer.Close();
    }

    public void DisplayGoals()
    {
        int count = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{++count}: {goal.GetConsoleString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {_totalScore}");
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("For which goal would you like to record an event? ");
        int choice = int.Parse(Console.ReadLine());

        _totalScore += _goals[choice - 1].RecordEvent();
    }
}