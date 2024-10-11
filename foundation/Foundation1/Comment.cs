using System;

public class Comment
{
    private string _commenterName;
    private string _text;

    public Comment(string commenterNameInput, string textInput)
    {
        _commenterName = commenterNameInput;
        _text = textInput;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }
    public string GetText()
    {
        return _text;
    }
}

