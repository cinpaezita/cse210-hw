using System;

public class Word
{
    private string _text;
    private bool _isHidden;
    //Initializes the word with the provied text
    public Word(string text)
    {
        _text = text;
    }
    //Hides the word
    public void Hide()
    {
        _isHidden = true;
    }
    //Shows the word
    public void Show()
    {
        _isHidden = false;
    }
    //Checks if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
    //Display
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}