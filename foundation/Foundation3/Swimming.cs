public class Swimming : Activity
{
    private int _swimmingLaps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _swimmingLaps = laps;
    }
    public override double GetDistance()
    {
        double distance = (_swimmingLaps * 50) / 1000;
        return distance;
    }

}