using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address addr2 = new Address("456 Center St", "Boise", "ID", "USA");

        Event lecture = new Lecture("Tech Talk", "Latest in AI", "Apr 5", "10:00 AM", addr1, "Dr. Smith", 100);
        Event reception = new Reception("Networking Event", "Meet professionals", "Apr 6", "6:00 PM", addr2, "rsvp@email.com");
        Event outdoor = new OutdoorGathering("Picnic", "Community picnic", "Apr 7", "12:00 PM", addr1, "Sunny");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine("STANDARD:");
            Console.WriteLine(e.GetStandardDetails());

            Console.WriteLine("\nFULL:");
            Console.WriteLine(e.GetFullDetails());

            Console.WriteLine("\nSHORT:");
            Console.WriteLine(e.GetShortDescription());

            Console.WriteLine("\n----------------------\n");
        }
    }
}