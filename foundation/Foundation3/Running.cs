public class Running : Activity
{
    private double _distance;

    public Running(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    protected override double CalculateDistance()
    {
        return _distance;
    }

    protected override string GetActivityName()
    {
        return "Running";
    }

}