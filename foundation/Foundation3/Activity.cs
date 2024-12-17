public abstract class Activity
{
    private string _date;
    private double _lengthInMinutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _lengthInMinutes = minutes;
    }

    protected abstract double CalculateDistance();

    protected virtual double CalculateSpeed()
    {
        return CalculateDistance() / _lengthInMinutes * 60;
    }

    protected virtual double CalculatePace()
    {
        return _lengthInMinutes / CalculateDistance();
    }
    protected abstract string GetActivityName();
    public virtual string GetSummary()
    {
        return $"{GetDate()} {GetActivityName()} ({GetMinutes()} min): Distance: {Math.Round(CalculateDistance(), 2)} miles, Speed: {Math.Round(CalculateSpeed(), 2)} mph, Pace: {Math.Round(CalculatePace(), 2)} min per mile";
    }

    protected string GetDate()
    {
        return _date;
    }

    protected double GetMinutes()
    {
        return _lengthInMinutes;
    }
}