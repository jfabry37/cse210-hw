
abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;
    
    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public void SetName(string shortName)
    {
        _shortName = shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public void SetPoints(string points)
    {
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return "";
    }
    public virtual string GetStringRepresentation()
    {
        return "";
    }

}