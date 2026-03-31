using System;
using System.IO;
class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool status)
        : base(name, description, points, status)
    {
        
    }

    public SimpleGoal() : base("", "", 0, false)
    {
        
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
    }

    public override int RecordEvent()
    {
        return MarkComplete();
    }
}