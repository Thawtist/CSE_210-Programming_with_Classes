using System;
class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    public void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }
}