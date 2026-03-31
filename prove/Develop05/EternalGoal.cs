using System;
using System.IO;

class EternalGoal : Goal
{
    private int _numberOfCompletions;
    public EternalGoal(string name, string description, int points, bool status, int completions)
        : base(name, description, points, status)
    {
        _numberOfCompletions = completions;
    }

    public EternalGoal() : base("", "", 0, false)
    {
        _numberOfCompletions = 0;
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        return GetPoints();
    }

    public override string GetFileSystemString()
    {
        return $"{base.GetFileSystemString()}#{_numberOfCompletions}";
    }

    public override string GetConsoleString()
    {
        return $"{base.GetConsoleString()} Completions:{_numberOfCompletions}";
    }
}