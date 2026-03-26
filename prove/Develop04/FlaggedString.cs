using System;

class FlaggedString
{
    private string _prompt;
    private bool _hasBeenUsed;

/// <summary>
/// Initializes a new instance of the <see cref="FlaggedString"/> class.
/// </summary>
/// <param name="prompt">The prompt.</param>
/// <param name="hasBeenUsed">If set to <c>true</c> the string has been used.</param>
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