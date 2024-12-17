public class Swimming : Activity
{
    private double _numberOfLaps;

    public Swimming(string date, double minutes, double laps) : base(date, minutes)
    {
        _numberOfLaps = laps;
    }

    protected override double CalculateDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62;
    }

    protected override string GetActivityName()
    {
        return "Swimming";
    }
}