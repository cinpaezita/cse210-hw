public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = (_minutes * _speed) / 60;
        return distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
}