

// Contains:
// Date, prompt, response





class JournalEntry
{
    private string _date;
    private string _entryQuestion;
    private string _journalEntry;

    private JournalQuestions _journalQuestions;

    public JournalEntry()
    {
        _date = "";
        _entryQuestion = "";
        _journalEntry = "";
        _journalQuestions = new JournalQuestions();
    }

    public JournalEntry(string date, string entryQuestion, string journalEntry)
    {
        // TODO Missing something here probably the date, something like _date = date
        _entryQuestion = entryQuestion;
        _journalEntry = journalEntry;
        _journalQuestions = new JournalQuestions();
    }

    public string CreateFileSystemString()
    {
        string outputString = "";

        outputString = $"{_date}#{_entryQuestion}#{_journalEntry}";

        return outputString;
    }

    public void CreateEntry()
    {
        string question = _journalQuestions.NextQuestion();

        Console.WriteLine(question);
        Console.Write("> ");
        string journalEntry = Console.ReadLine();

        DateTime = theCurrentTime = DateTime.Now;

        this._date = theCurrentTime.ToShortDateString();
        this._entryQuestion = question;
        this._journalEntry = journalEntry;
    }

    public void CreateEntryWithData(String date, string prompt, string response)
    {
        this._date = date;
        this._entryQuestion = prompt;
        this._journalEntry = response;
    }









    // public string CreateFileSystemString()
    // {
    //     string outputString = "";

    //     outputString = $"{_date}#{_entryQuestion}#{_journalEntry}";

    //     return outputString;
    // }





    // public void setDate()
    // {
    //     DateTime theCurrentTime = DateTime.Now;
    //     string dateText = theCurrentTime.ToShortDateString();
    //     _date = dateText;
    // }

}