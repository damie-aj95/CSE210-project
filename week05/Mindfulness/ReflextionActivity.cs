using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you overcame something difficult."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?"
    };

    private Random _rand = new Random();

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "Reflect on meaningful experiences.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        DateTime end = DateTime.Now.AddSeconds(_timer);

        while (DateTime.Now < end)
        {
            DisplayQuestions();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        return _questions[_rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
        ShowSpinner(4);
    }
}
