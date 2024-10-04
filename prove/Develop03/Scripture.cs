using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    //Initializes the reference and split the text into words
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        //Split the input text by spaces and each word to the list
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
       
    }
    //Hides a specific number of random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }

    }
    //Display
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()} "+ string.Join(" ", displayWords);

    }
    //Checks if all words are completely hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}