using System;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity baseActivity = new BaseActivity("Breathing",
            "This activity will help you relax with breathing exercises");

        baseActivity.DisplayGreeting();
        baseActivity.DisplayDescription();
    }
}