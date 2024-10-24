using System;
public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return "SimpleGoal:" + _shortName + "," + _description + "," + _points + "," + _isComplete;
    }

    public override string GetDetailString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return status + " " + _shortName + "(" + _description + ")";
    }
}