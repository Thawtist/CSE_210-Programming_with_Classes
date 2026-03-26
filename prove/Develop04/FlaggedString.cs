using System;

class FlaggedString
{
    private string _prompt;
    private bool _hasBeenUsed;

    public FlaggedString(string prompt, bool hasBeenUsed)
    {
        _prompt = prompt;
        _hasBeenUsed = hasBeenUsed;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public bool GetHasBeenUsed()
    {
        return _hasBeenUsed;
    }

    public void SetHasBeenUsed(bool value)
    {
        _hasBeenUsed = value;
    }
}