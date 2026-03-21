using System;
using System.Collections.Generic;

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

    public int NumberOfUnhiddenWords()
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
        foreach (string wword in text.Split(' '))
        {
            Word tempWord = new Word(wword);
            words.Add(tempWord);
        }
        return words;
    }

    public bool HideSomeWords()
    {
        int remaining = NumberOfUnhiddenWords();

        if (remaining <= 0)
        {
            return true;
        }
        else if (remaining <= 3)
        {
            foreach (Word word in _words)
            {
                word.Hide();
            }
            return true;
        }
        else
        {
            int wordsHidden = 0;
            Random rn = new Random();

            while (wordsHidden < 3)
            {
                int randomIndex = rn.Next(0, _words.Count);

                if (!_words[randomIndex].IsHidden())
                {
                    _words[randomIndex].Hide();
                    wordsHidden++;
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