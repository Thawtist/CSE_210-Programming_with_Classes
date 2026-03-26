using System;

class ListingActivity : BaseActivity
{
    private List<FlaggedString> _prompts;
    private void SetPrompts()
    {
        _prompts = new List<FlaggedString>();

        _prompts.Add(new FlaggedString("Who are people that you appreciate?", false));
        _prompts.Add(new FlaggedString("What are personal strengths of yours?", false));
        _prompts.Add(new FlaggedString("Who are people that you have helped this week?", false));
        _prompts.Add(new FlaggedString("When have you felt the Holy Spirit this month?", false));
        _prompts.Add(new FlaggedString("Who are some of your personal heroes?", false));
    }

    private void ResetPromptsUsage()
    {
        foreach (FlaggedString prompt in _prompts)
        {
            prompt.SetHasBeenUsed(false);
        }
    }

    public ListingActivity(string name, string description) : base(name, description)
    {
        SetPrompts();
    }

    public void RunActivity()
    {
        Console.Clear();
        ResetPromptsUsage();

        DisplayGreeting();
        DisplayDescription();
        ObtainDuration();

        // TODO Display a countdown . . .
        // TODO Finish program lol
        
    }
}