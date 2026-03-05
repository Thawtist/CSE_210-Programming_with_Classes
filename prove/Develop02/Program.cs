using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool done = false;
        int userResponse;
        do
        {
            userResponse = menu.ProcessMenu();
            switch (userResponse)
            {
                case 1:
                // TODO Create new Journal Entry
                // TODO Add entry to list of journal entries
                break;
                case 2:
                // TODO Display Journal Entries
                break;
                case 3:
                // TODO Save journal to file
                break;
                case 4:
                // TODO Load journal from file
                break;
                case 5:
                    done = true;
                    break;
            }
        } while (!done);

        






        // Console.WriteLine("Hello Develop02 World!");
    }
}