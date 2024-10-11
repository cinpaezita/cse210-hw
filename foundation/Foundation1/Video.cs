using System;

public class Video
{
    private string _title;
    private string _author;
    private int _lenghtInSeconds;
    private List<Comment> _comments;

    public Video(string titleInput, string authorInput, int lenghtInSecondsInput)
    {
        _title = titleInput;
        _author = authorInput;
        _lenghtInSeconds = lenghtInSecondsInput;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    
    }
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }
    public int GetLengthInSeconds()
    {
        return _lenghtInSeconds;
    }
}