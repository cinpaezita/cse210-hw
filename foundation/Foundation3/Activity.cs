// To fix the month format in the output, I found the section on working with date and times in the site net-tutorial.com
// https://csharp.net-tutorials.com/es/401/tipos-de-datos-/working-with-dates-time/
using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }
    public virtual double GetSpeed()
    {
        double distance = GetDistance();
        double speed = (distance / _minutes) * 60;
        return speed;
    }
    public virtual double GetPace()
    {
        double distance = GetDistance();
        double pace = _minutes / distance;
        return pace;
    }

    public virtual string GetSummary()
    {
        string formattedDate = _date.ToString("dd MMM yyyy", System.Globalization.CultureInfo.InvariantCulture);
        return $"   ° {formattedDate} {GetType().Name} ({_minutes} min): Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }

}
