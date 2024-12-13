public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal (string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string isComplete;

        if (IsComplete())
        {
            isComplete = "X";
        }
        else
        {
            isComplete = " ";
        }
        
        return $"[{isComplete}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    public string GetShortName()
    {
        return _shortName;
    }

    protected string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return int.Parse(_points);
    }
}