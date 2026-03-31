using System;
using System.IO;

class CheckListGoal : Goal
{
    private int _numberOfCompletions;
    private int _maxGoal;
    private int _bonusPoints;
    public CheckListGoal(string name, string description, int points, bool status, int numberOfCompletions, int maxGoal, int bonusPoints)
        : base(name, description, points, status)
    {
        _numberOfCompletions = numberOfCompletions;
        _maxGoal = maxGoal;
        _bonusPoints = bonusPoints;
    }
    public CheckListGoal() : base("", "", 0, false)
    {
        _numberOfCompletions = 0;
        _maxGoal = 0;
        _bonusPoints = 0;
    }

    private void ObtainMaxGoal()
    {
        Console.WriteLine("Please enter the maximum number of times this goal can be completed: ");
        _maxGoal = int.Parse(Console.ReadLine());
    }

    private void ObtainBonusPoints()
    {
        Console.WriteLine("Please enter the number of bonus points associated with this goal: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
        ObtainMaxGoal();
        ObtainBonusPoints();
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        if (_numberOfCompletions >= _maxGoal)
        {
            MarkComplete();
            return GetPoints() + _bonusPoints;
        }
        else
            return GetPoints();
    }

    public override string GetFileSystemString()
    {
        return $"{base.GetFileSystemString()}#{_numberOfCompletions}#{_maxGoal}#{_bonusPoints}";
    }

    public override string GetConsoleString()
    {
        return $"{base.GetConsoleString()} Completions: {_numberOfCompletions} of {_maxGoal}";
    }
}