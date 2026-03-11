
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Collections.Generic;



// EventAttributes:List<

class Journal
{
    private List<JournalEntry> _entries;

    public Journal()
    {
        _entries = new List<JournalEntry>();
    }

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (JournalEntry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    
    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    public void ReadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            JournalEntry entry = new JournalEntry();
            entry.CreateEntryWithData(date, question, entryText);    
            this.AddEntry(entry);
        }
    }










//     public List<Entry> _entries;

//     // methods
//     // save to file
//     public void saveToFile()
//     {
//         // Don't forget to put this at the top, so C# knows where to find the StreamWriter class


//         string filename = "Journal.txt";

//         using (StreamWriter outputFile = new StreamWriter(filename))
//         {
//             // You can add text to the file with the WriteLine method
//             outputFile.WriteLine("This will be the first line in the file.");
            
//             // You can use the $ and include variables just like with Console.WriteLine
//             string color = "Blue";
//             outputFile.WriteLine($"My favorite color is {color}");
// }
//     }
//     // read file
//     public void readFromFile()
//     {
//         string filename = "Journal.txt";
//         string[] lines = System.IO.File.ReadAllLines(filename);

//         foreach (string line in lines)
//             {
//                 string[] parts = line.Split(",");

//                 string firstName = parts[0];
//                 string lastName = parts[1];
//             }
//     }

}