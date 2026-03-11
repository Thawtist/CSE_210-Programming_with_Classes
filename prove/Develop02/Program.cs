using System;

class Program
{
    private static string ObtainFileName(string prompt)
    {
        Console.WriteLine(prompt);
        string fileName = Console.ReadLine();
        return fileName;
    }
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();

        Menu menu = new Menu();//"Journal Program", "Write, display, save and load your journal");
        // menu.DisplayTitle();
        string fileName = "";
        int response = 0;
        while (response != 5)
        // bool done = false;
        // int userResponse;
        // do
        {
            // userResponse = menu.ProcessMenu();
            response = menu.ProcessMenu();
            // switch (userResponse)
            switch(response)

            {
                case 1:
                    // TODO Create new Journal Entry
                    // TODO Add entry to list of journal entries
                    JournalEntry journalEntry = new JournalEntry();
                    journalEntry.CreateEntry();
                    journalEntry.DisplayEntry();
                    newJournal.AddEntry(journalEntry);
                    break;
                case 2:
                    // TODO Display Journal Entries
                    newJournal.Display();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
                case 3:
                    // TODO Save journal to file
                    fileName = ObtainFileName("Enter file name of where to save Journal: ");
                    newJournal.WriteToFile(fileName);
                    break;
                case 4:
                    // TODO Load journal from file
                    fileName = ObtainFileName("File Name from which to read Journal: ");
                    newJournal.ReadFromFile(fileName);
                    break;
                case 5:
                    // done = true;
                    break;
                default:
                Console.WriteLine("Error, please input valid value.");
                    break;
            }
        // } while (!done);
        }

        






        // Console.WriteLine("Hello Develop02 World!");
    }
}