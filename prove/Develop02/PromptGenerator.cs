using System;
public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "What made me smile today?",
            "What is something I learned today?",
            "What is one thing I accomplished today that I'm proud of?",
            "How did I challenge myself today?",
            "What is something I am greatful for today?",
            "Did I help someone today today? How?",
            "What surprised me today?",
            "If I had one thing I could do over today, what would it be?",
            "What is a goal I want to set for tomorrow?",
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}