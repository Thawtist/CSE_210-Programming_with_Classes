class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey Bob");

        int x = 10;

        string name = (x > 10) ? "Bob" : "Betty";

        Console.WriteLine(name);

        if (x > 10)
        {
            name = "Bob";
        }
        else
        {
            name = "Betty";
        }

        string? name2 = null;
        int? length = name2?.Length;

        Console.WriteLine(length);
        Console.WriteLine(name2?.Length);

        name2 = "Bubby";
        length = name2?.Length;
        Console.WriteLine(length);

        name2 ??= "Jeannie";
        Console.WriteLine(name2);

        string? name3 = null;
        name3 ??= "Jeannie";
        Console.WriteLine(name3);
    }
}