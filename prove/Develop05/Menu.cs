using System;





class Menu
{
    public int DisplayMainMenu()
    {
        int response = 0;
        
        while(response < 1 || response > 6)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            
            response = int.Parse(Console.ReadLine());
        }
    }
}