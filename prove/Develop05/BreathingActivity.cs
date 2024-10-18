using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing")
    {}

    public void Run()
    {
        DisplayStartingMessage();

        int duration = _duration;
        int timeElapsed = 0;
        while (timeElapsed < duration)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            timeElapsed += 10;
            Console.WriteLine();
            
        }
        DisplayEndingMessage();
    }
}