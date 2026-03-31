using System;
using System.IO;


abstract class Goal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;


    public Goal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
        _goalType = base.ToString();
    }

    public string GetName()
    {
        return _name;
    }


    public void SetName()
    {
        Console.Write("Pleas enter the name of your goal: ");
        _name = Console.ReadLine();
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription()
    {
        Console.Write("Please enter a description of your goal: ");
        _description = Console.ReadLine();
    }

    public int GetPoints()
    {
        return _numberOfPoints;
    }

    public void SetPoints()
    {
        Console.Write("Please enter the number of points associated with this goal: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    public bool GetStatus()
    {
        return _status;
    }

    public virtual string GetGoalType()
    {
        return _goalType;
    }

    public void SetGoalType(string GoalType)
    {
        _goalType = GoalType;
    }

    public virtual string GetConsoleString()
    {
        string statusMarker = " ";
        if (_status)
        {
            statusMarker = "X";
        }
        return $"Goal Information: {_name}, {_description}, {_numberOfPoints}, {_status}, {_goalType}";
    }

    public virtual string GetFileSystemString()
    {
        return $"{_goalType}#{_name}#{_description}#{_numberOfPoints}#{_status}";
    }

    public int MarkComplete()
    {
        _status = true;
        return _numberOfPoints;
    }

    public abstract int RecordEvent();

    public abstract void CreateGoal();
}