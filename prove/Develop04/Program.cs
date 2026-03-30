using System;

class Program
{
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <remarks>
        /// This program will display a menu to the user and allow them to select
        /// which activity to run. The activities include breathing exercises,
        /// reflection, and listing positive things in their life.
        /// </remarks>
    static void Main(string[] args)
    {
        // BreathingActivity breathingActivity = new BreathingActivity();
        // ReflectionActivity reflectionActivity = new ReflectionActivity();
        // ListingActivity listingActivity = new ListingActivity();

        BreathingActivity breathingActivity = new BreathingActivity(
            "Breathing",
            "This activity will help you relax by guiding your breathing."
        );

        ReflectionActivity reflectionActivity = new ReflectionActivity(
            "Reflection",
            "This activity helps you reflect on meaningful experiences."
        );

        ListingActivity listingActivity = new ListingActivity(
            "Listing",
            "This activity helps you list positive things in your life."
        );






        int response = 0;
        while(response != 4)
        {
            response = Menu.DisplayMenu();

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

        // breathingActivity.RunActivity();

        Console.WriteLine("Goodbye!");
    }
}