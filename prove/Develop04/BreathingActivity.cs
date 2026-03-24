using System;

class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void RunActivity()
    {
        Console.Clear();
        DisplayGreeting();
        DisplayDescription();
        ObtainDuration();

        Console.Clear();
        RunCountDown("\n\nGet ready", 3);

        Console.Clear();
        StartTimer();
        while(!HasTimerExpired())
        {
            Console.WriteLine();
            RunCountDown("Breathe in...", 4);
            Console.WriteLine();
            RunCountDown("Breathe out...", 6);
        }
        // DisplaySpinner("Hey Bob", 4);

        DisplayEnding();
    }
}