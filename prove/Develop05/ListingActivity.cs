using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("", "")
    {
        _count = 0;
        _prompts = new List<string>();
    }
    public void Run()
    {
        List<string> responses = GetListFromUser();
        _count = responses.Count();
    }

    private string GetRandomPrompt()
    {
        return "";
    }

    private List<string> GetListFromUser()
    {
        return new List<string>();
    }
}