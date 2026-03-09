

// Contains:
// Date, prompt, response





class Entry
{
    public string _date;
    public string _prompt;
    public string _response;


    public string CreateFileSystemString()
    {
        string outputString = "";

        outputString = $"{_date}#{_entryQuestion}#{_journalEntry}";

        return outputString;
    }





    // public void setDate()
    // {
    //     DateTime theCurrentTime = DateTime.Now;
    //     string dateText = theCurrentTime.ToShortDateString();
    //     _date = dateText;
    // }

}