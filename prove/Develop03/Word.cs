using System;
using System.Diagnostics;

class Word
{
    public string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }



    public bool IsHidden()
    {
        return _hidden;
    }

    public void Show()
    {
        
    }

    public void HideWord(bool hidden = true)
    {
        _hidden = hidden;
    }

    public string GetWordString()
    {
        string tempString = "";
        if (!IsHidden())
        {
            tempString = _word;
        }
        else
        {
            for (int i = 0; i < _word.Length; i++)
            {
                tempString += "_";
            }
        }
        return tempString;
    }

    public void DisplayWord()
    {
        Console.WriteLine($"{GetWordString()}");
    }
}