using System;


class ReflectingActivity : BaseActivity
{

    private List<FlaggedString> _questions;

    private void SetPromptsAndQuestions()
    {
        _prompts = new List<FlaggedString>();
        _questions = new List<FlaggedString>();

        _prompts.Add(new FlaggedString("Think of a time when you did something really difficult.", false));
        _prompts.Add(new FlaggedString("Think of a time when you helped someone in need.", false));
        _prompts.Add(new FlaggedString("Think of a time when you stood up for someone else.", false));
        _prompts.Add(new FlaggedString("Think of a time when you did something truly selfless.", false));

        _questions.Add(new FlaggedString("Why was this experience meaningful to you?", false));
        _questions.Add(new FlaggedString("Have you ever done anything like this before?", false));
        _questions.Add(new FlaggedString("How did you get started?", false));
        _questions.Add(new FlaggedString("How was the experience? Did you learn anything from it?", false));
        _questions.Add(new FlaggedString("What is your favorite thing about this experience?", false));
        _questions.Add(new FlaggedString("What could you learn from this experience that you can apply to other situations?", false));
        _questions.Add(new FlaggedString("How can you keep this experience in mind in the future?", false));


    }

    private void ResetPromptsUsage()
    {
        foreach (FlaggedString prompt in _prompts)
        {
            prompt.SetHasBeenUsed(false);
        }
        foreach (FlaggedString question in _questions)
        {
            question.SetHasBeenUsed(false);
        }
    }
    public ReflectionActivity(string name, string description) : base(name, description)
    {
        SetPromptsAndQuestions();
    }

    public void RunActivity()
    {
        Console.Clear();
        ResetPromptsUsage();


        DisplayGreeting();
        DisplayDescription();
        ObtainDuration();


        Console.Clear();
        RunCountDown("\n\nGet ready", 3);

        Console.Clear();
        
        Console.WriteLine(GetPromptString(_prompts));
        Console.WriteLine("\nPress enter once you have something in mind.");
        Console.ReadLine();


        Console.Clear();
        StartTimer();
        while (!HasTimerExpired())
        {
            Console.WriteLine();
            RunCountDown(GetPromptString(_questions) + ": ", 10);
        }


        DisplayEnding();
    }
}