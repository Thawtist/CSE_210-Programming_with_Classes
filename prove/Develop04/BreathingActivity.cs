using System;

class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void RunActivity()
    {
        DisplayGreeting();
        DisplayDescription();
        ObtainDuration();
        DisplaySpinner("Hey Bob", 4);
    }
}