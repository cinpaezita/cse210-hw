using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"\n{_description}");
        Console.WriteLine("How long in seconds, would you like for your sessions?: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }
    private void ShowSpinner(int seconds)
    {

    }
    public void ShowCountDown(int seconds)
    {

    }


}