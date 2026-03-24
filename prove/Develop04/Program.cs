using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();




        int response = 0;
        while(response != 4)
        {
            response = Menu.DiisplayMenu();

            if(response == 1)
            {
                breathingActivity.RunActivity();
            }
            else if (response == 2)
            {
                reflectionActivity.RunActivity();
            }
            else if (response == 3)
            {
                listingActivity.RunActivity();
            }
        }
        // BaseActivity baseActivity = new BaseActivity("Breathing",
        //     "This activity will help you relax with breathing exercises");

        // BreathingActivity breathingActivity = new BreathingActivity("Breathing",
        //     "This activity will help you relax with breathing exercises");

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