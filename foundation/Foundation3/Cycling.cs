public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    protected override double CalculateDistance()
    {
        return CalculateSpeed() / 60 * GetMinutes();
    }

    protected override double CalculateSpeed()
    {
        return _speed;
    }

    protected override string GetActivityName()
    {
        return "Cycling";
    }
}