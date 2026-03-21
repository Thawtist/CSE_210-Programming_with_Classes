using System;

class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    // Read-only access to the word (optional, if needed)
    public string GetWord()
    {
        return _word;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public string GetDisplayText()
    {
        if (!_hidden)
        {
            return _word;
        }
        else
        {
            return new string('_', _word.Length);
        }
    }

    public void DisplayWord()
    {
        Console.Write(GetDisplayText());
    }
}