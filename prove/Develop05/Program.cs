using System;



class Program
{
    static void Main(string[] args)
    {

        SimpleGoal mySimpleGoal = new SimpleGoal();

        mySimpleGoal.CreateGoal();
        Console.WriteLine(mySimpleGoal.GetConsoleString());


        // Menu menu = new Menu();
        // Goals goals = new Goals();

        // int choice = 0;

        // // Main Menu loop
        // while (choice != 6)
        // {
        //     Console.Clear();
        //     goals.DisplayGoals();
        //     Console.WriteLine();
        //     choice = menu.DisplayMainMenu();

        //     // Process Choices
        //     switch (choice)
        //     {
        //         case 1:
        //             int createGoalChoice = 0;
        //             createGoalChoice = menu.DisplayCreateGoalMenu();
        //             switch (createGoalChoice)
        //             {
        //                 case 1:

        //             }
        //     }

        // }


    }
}