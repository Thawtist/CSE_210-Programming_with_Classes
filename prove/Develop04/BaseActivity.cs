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
        // Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }

    public void DisplaySpinner(string Message, int seconds)
    {
        // DateTime currentTime = DateTime.Now;
        // DateTime endTime = currentTime.AddSeconds(seconds);
        // int sleepTime = 100; // This is in milliseconds
        // string animationString = "-\\|/"; // The double backslash is just one character
        // int index = 0;

        // Console.CursorVisible = false;
        // // Console.Clear();

        // Console.Write($"{Message} ");

        // while(DateTime.Now < endTime)
        // {
        //     Console.Write(animationString[index++ % animationString.Length]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }


        // Console.CursorVisible = true;
        
        int countDown = seconds * 1000;
        int index = 0;
        int sleepTime = 100; // This is in milliseconds
        Console.Write(Message);
        string spinner = "-\\|/";
        while (countDown > 0)
        {
            Console.Write($"{spinner[index]}");
            Console.Write("\b");
            Thread.Sleep(sleepTime);
            countDown -= sleepTime;
            index++;
            index %= spinner.Length;
        }

    }

    public void DisplayEnding()
    {
        DisplaySpinner("\n\nWell done!", 2);
        DisplaySpinner($"You have completed {_duration} seconds of the {_name} Activity", 3);
    }

    /// <summary>
    /// Displays a countdown from the given number of seconds,
    /// prepending the given message.
    /// </summary>
    /// <param name="Message">The message to display before the countdown.</param>
    /// <param name="seconds">The number of seconds to count down from.</param>
    public void RunCountDown(string Message, int seconds)
    {
        int countDown = seconds;
        Console.Write(Message);
        while (countDown > 0)
        {
            Console.Write($"{countDown}");
            if (countDown >= 9)
                Console.Write("\b\b  \b\b");
            else
                Console.Write("\b");
            Thread.Sleep(1000);
            countDown -= 1;
        
        }
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    public void ObtainDuration()
    {
        Console.WriteLine("How long, in seconds, would you like to do this activity?");
        bool receivedCorrectInput = false;

        while (!receivedCorrectInput)
        {
            try
            {
                _duration = int.Parse(Console.ReadLine());
                if (_duration <= 0)
                {
                    throw new Exception("Must be a positive number.");
                }
                receivedCorrectInput = true;
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Input must be a positive number.");
            }
        }
        // Console.Write("> ");
        // _duration = int.Parse(Console.ReadLine());
    }

    public string GetPromptString(List<FlaggedString> strings)
    {
        var random = new Random();
        int index = random.Next(strings.Count);
        if (!strings[index].GetHasBeenUsed())
        {
            strings[index].SetHasBeenUsed(true);
            return strings[index].GetPrompt();
        }
        else
        {
            foreach (FlaggedString s in strings)
            {
                if (!s.GetHasBeenUsed())
                {
                    s.SetHasBeenUsed(true);
                    return s.GetPrompt();
                }
            }
            foreach (FlaggedString s in strings)
            {
                s.SetHasBeenUsed(false);
            }
            return strings[index].GetPrompt();
        }
        
    }



}