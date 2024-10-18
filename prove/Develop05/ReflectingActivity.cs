using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<int> _usedPrompts; //To track used prompts
    private List<int> _usedQuestions; //To track used questions
    
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in others aspects of your life.")
    {
        _prompts = new List<string>()
        {
            "--- Think of a time when you stood up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless. ---"
        };
        _questions = new List<string>()
        {
            "> Why was this experience meaningful to you? ",
            "> Have you ever done anything like this before? ",
            "> How did you get started? ",
            "> How did you feel when it was complete? ",
            "> What made this time different than other times when you were not as successful? ",
            "> What is your favorite thing about this experience? ",
            "> What could you learn from this experience that applies to other situations? ",
            "> What did you learn about yourself through this experience? ",
            "> How can you keep this experience in mind in the future? "
        };

        _usedPrompts = new List<int>();
        _usedQuestions = new List<int>();

    }
    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        DisplayPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("When you have something in mind, press enter to continue...");
        Console.ReadLine();
        ShowCountDown(5);

        DisplayQuestions();

        int duration = _duration;
        int timeElapsed = 0;

        while (timeElapsed < duration)
        {
            string question = GetRandomQuestion();
            Console.Write(question);
            ShowSpinner(5);
            timeElapsed += 5;

        }
        DisplayEndingMessage();


    }
    public string GetRandomPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear(); //Reset the used prompts
        }

        int index = new Random().Next(_prompts.Count);
        while (_usedPrompts.Contains(index))
        {
            index = new Random().Next(_prompts.Count); //Generate a new index if already exits
        }
        _usedPrompts.Add(index);
        return _prompts[index];

    }
    public string GetRandomQuestion()
    {
        if (_usedQuestions.Count == _questions.Count)
        {
            _usedQuestions.Clear(); //Reset the used prompts
        }

        int index = new Random().Next(_questions.Count);
        while (_usedQuestions.Contains(index))
        {
            index = new Random().Next(_questions.Count); //Generate a new index if already exits
        }
        _usedQuestions.Add(index);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
    }
    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience: ");

    }
}