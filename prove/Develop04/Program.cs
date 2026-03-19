using System;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity baseActivity = new BaseActivity("Breathing",
            "This activity will help you relax with breathing exercises");

        BreathingActivity breathingActivity = new BreathingActivity("Breathing",
            "This activity will help you relax with breathing exercises");

        // baseActivity.DisplayGreeting();
        // baseActivity.DisplayDescription();

        // baseActivity.DisplaySpinner("Hey Bob", 5);

        // breathingActivity.DisplayGreeting();
        // breathingActivity.DisplayDescription();
        // breathingActivity.ObtainDuration();
        // breathingActivity.DisplaySpinner("Hey Bob", 4);

        breathingActivity.RunActivity();
    }
}