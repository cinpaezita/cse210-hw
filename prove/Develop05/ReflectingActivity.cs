using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("", "")
    {
        _prompts = new List<string>();
        _questions = new List<string>();
    }
    public void Run()
    {

    }
    private string GetRandomPrompt()
    {
        return "";

    }
    private string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {

    }
}