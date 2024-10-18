using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = new List<string>
        {
            "--- Who are people that you appreciate? ---",
            "--- What are personal strengths of yours? ---",
            "--- Who are people that you have helped this week? ---",
            "--- When have you felt the Holy Ghost this month? ---",
            "--- Who are some of your personal heroes? ---"
        };
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        List<string> responses = GetListFromUser();
        _count = responses.Count();

        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine("Enter items (type 'done' to finish):");
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;
            responses.Add(input);
        }
        return responses;
    }
}