using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2022", 30, 3.0));
        // activities.Add(new Running("Rucking", 278, 18.6)); // This was my rucking trip the other day, I figured I'd put it in here to see my mph and pace, ha ha
        activities.Add(new Cycling("04 Nov 2022", 45, 12.0));
        activities.Add(new Swimming("05 Nov 2022", 40, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}