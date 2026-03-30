using System;

class Menu
{
    /// <summary>
    /// Displays the main menu and prompts the user to select an option.
    /// </summary>
    /// <returns>The selected option as an integer.</returns>
    public static int DisplayMenu()
    {
        // CLEAR BUFFER BEFORE ASKING FOR INPUT
        while (Console.KeyAvailable)
        {
            Console.ReadKey(true);
        }

        Console.Clear();

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