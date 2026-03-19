using System;
using System.ComponentModel.DataAnnotations;
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
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }

    public void DisplaySpinner(string message, int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
        int sleepTime = 100; // This is in milliseconds
        string animationString = "-\\|/"; // The double backslash is just one character
        int index = 0;

        Console.CursorVisible = false;
        // Console.Clear();

        Console.Write($"{message} ");

        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }


        Console.CursorVisible = true;
    }

    public void DisplayEnding()
    {
        
    }

    public void RunCountDown(string message, int seconds)
    {

    }

    public void StartTimer()
    {
        
    }

    public bool HasTimerExpired()
    {
        return false; // TODO Return true if the timer has expired
    }

    public void ObtainDuration()
    {
        Console.WriteLine("How long, in seconds, would you like to do this activity?");
        Console.Write("> ");
        _duration = int.Parse(Console.ReadLine());
    }

}