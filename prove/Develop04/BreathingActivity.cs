using System;

class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }

    /// <summary>
    /// Runs the activity.
    /// </summary>
    /// <remarks>
    /// Clears the console and displays the greeting and description.
    /// Then, it asks the user for the duration of the activity.
    /// After that, it waits for 3 seconds and then starts the activity.
    /// The activity consists of prompting the user to breathe in and out.
    /// The activity ends after the set duration.
    /// </remarks>
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