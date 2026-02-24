using System;

class MyPrep1Class
{
    public static void Main(string[] args)
    {
        // int x = 10;
        // x = 10;
        //! x = "bob";

        // Console.WriteLine("Hello Prep1 World!");

        string firstName;
        string lastName;

        Console.Write("What is your first name: ");
        firstName = Console.ReadLine();

        Console.Write("What is your last name: ");
        lastName = Console.ReadLine();
        // lastName.ToUpper();

        // Console.WriteLine(lastName, firstName);
        // Console.WriteLine($"{{{firstName}}} {lastName}");
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}