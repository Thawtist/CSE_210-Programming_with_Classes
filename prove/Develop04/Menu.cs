using System;

class Menu
{
    public static int DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice: ");

        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
}