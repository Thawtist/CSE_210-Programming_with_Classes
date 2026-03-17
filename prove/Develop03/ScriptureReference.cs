using System;
using System.ComponentModel;
using System.Text;

class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    // private int _firstVerse;
    // private int _lastVerse;
    private int[] _verse;


    public string GetScriptureReferenceString()
    {
        if(_verse.Length == 1)
        {
            return $"{_bookName} {_chapter}:{_verse[0]}";
        }
        else if (_verse.Length == 2)
        {
            return $"{_bookName} {_chapter}:{_verse[0]}-{_verse[1]}";
        }
        else
        {
            return "Invalid Scripture Reference";
        }
    }

    public ScriptureReference(string name, int chapter, int verse)
    {
        _verse = new int[1];
        _bookName = name;
        _verse[0] = verse;
        _chapter = chapter;
    }
    public ScriptureReference(string name, int chapter, int startVerse, int endVerse)
    {
        _verse = new int[2];
        _bookName = name;
        _verse[0] = startVerse;
        _verse[1] = endVerse;
        _chapter = chapter;
    }

    public void ShowScriptureReference()
    {
        Console.WriteLine(GetScriptureReferenceString());
    }

    public string GetScriptureReference()
    {
        return GetScriptureReferenceString();
    }



}