using System;
using System.IO;
using System.Collections;
using System.Security.Cryptography;



class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Goals goals = new Goals();

        int choice = 0;

        // Main Menu loop
        while (choice != 6)
        {
            Console.Clear();
            goals.DisplayScore();
            Console.WriteLine();
            choice = menu.DisplayMainMenu();

            // Process Choices
            switch (choice)
            {
                // Create a new Goal
                case 1:
                    int createGoalChoice = 0;
                    createGoalChoice = menu.DisplayCreateGoalMenu();
                    switch (createGoalChoice)
                    {
                            case 1:
                            SimpleGoal mySimpleGoal = new SimpleGoal();
                            mySimpleGoal.CreateGoal();
                            goals.AddGoal(mySimpleGoal);
                            break;
                        case 2:
                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.CreateGoal();
                            goals.AddGoal(eternalGoal);
                            break;
                        case 3:
                            CheckListGoal checklistGoal = new CheckListGoal();
                            checklistGoal.CreateGoal();
                            goals.AddGoal(checklistGoal);
                            break;
                    }
                    break;
                case 2:
                    goals.DisplayGoals();
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    break;
                case 3:
                    goals.SaveGoals();
                    break;
                case 4:
                    goals.LoadGoals();
                    break;
                case 5:
                    goals.RecordEvent();
                    break;
                default:
                    break;
            }

                    


        

        // SimpleGoal mySimpleGoal = new SimpleGoal();

        // mySimpleGoal.CreateGoal();
        // Console.WriteLine(mySimpleGoal.GetConsoleString());


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

        }


    }
}