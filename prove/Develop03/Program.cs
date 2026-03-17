using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        Scripture sr = new Scripture("Matthew", 28, 19, "But seek first the kingdom of God, and all these things will be added to you as well.");
        Scripture sr1 = new Scripture("John", 3, 16, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Scripture sr2 = new Scripture("Ether", 12, 27, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me; and have faith in me; then will I make weak things become strong unto them. ");
        Scripture sr3 = new Scripture("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Scripture sr4 = new Scripture("Mosiah", 2, 17, "And behold; I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
        Scripture sr5 = new Scripture("Helaman",5,12,"And now; my sons; remember; remember that it is upon the rock of our Redeemer; who is Christ; the Son of God; that ye must build your foundation; that when the devil shall send forth his mighty winds; yea; his shafts in the whirlwind; yea; when all his hail and his mighty storm shall beat upon you; it shall have no power over you to drag you down to the gulf of misery and endless wo; because of the rock upon which ye are built; which is a sure foundation; a foundation whereon if men build they cannot fall.");

        scriptures.Add(sr);
        scriptures.Add(sr1);
        scriptures.Add(sr2);
        scriptures.Add(sr3);
        scriptures.Add(sr4);
        scriptures.Add(sr5);

        int count = 1;
        Console.Clear();
        foreach (Scripture scripture in scriptures)
        {
            Console.WriteLine($"{count}. {scripture.GetScriptureReference()}");
            count++;
        }
        Console.WriteLine("This is a scripture memorization tool.");
        Console.WriteLine("Please enter the number of the scripture you would like to memorize.");
        int selectedScripture = int.Parse(Console.ReadLine()) - 1;
        Debug.Assert(selectedScripture >= 0);
        Debug.Assert(selectedScripture < scriptures.Count);


        string input = "a";
        bool finished = false;
        while (input!= "q" && !finished)
        {
            Console.Clear();
            Console.WriteLine("Enter 'q' to quit, press enter to remove words: ");

            scriptures[selectedScripture].ShowScripture();
            finished = scriptures[selectedScripture].HideSome_Words();
            if(!finished)
            {
                input = Console.ReadLine();
            }
        }
    }
}