using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private List<Word> _words;
    private ScriptureReference _reference;

    public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(name, chapter, verse);
        _words = ConvertToWords(text);
    }

    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new ScriptureReference(name, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = ConvertToWords(text);
    }

    public int NumberOfUnhidden_words()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

    private List<Word> ConvertToWords(string text)
    {
        List<Word> words = new List<Word>();
        foreach(string wword in text.Split(' '))
        {
            Word tempWord = new Word(wword);
            words.Add(tempWord);
            tempWord.HideWord(false);
        }
        return words;
        }

    public bool HideSome_Words()
    {
        int numberOfRemaining_words = NumberOfUnhidden_words();
        if (numberOfRemaining_words <= 0)
        {
            return true;
        }
        else if (numberOfRemaining_words <= 3)
        {
            foreach(Word word in _words)
            {
                word.HideWord();
            }
            return true;
        }
        else
        {
            int _wordsHidden = 0;
            Random rn = new Random();
            while(_wordsHidden < 3)
            {
                int randomNumber = rn.Next(0, _words.Count);
                if (!_words[randomNumber].IsHidden())
                {
                    _words[randomNumber].HideWord();
                    _wordsHidden++;
                }
            }
        }
        return false;
    }

    public void ShowScripture()
    {
        _reference.ShowScriptureReference();
        foreach (Word word in _words)
        {
            Console.Write(" ");
            word.DisplayWord();
        }
    }

    public string GetScriptureReference()
    {
        return _reference.GetScriptureReference();
    }






}