class Running : Activity
{
    private double _distance;
    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override string GetSpeed()
    {
        double speed = _distance / (GetDuration() / 60.0);
        return $"Speed {speed:f1} mph";
    }
    public override string GetDistance()
    {
        return $"Distance {_distance:f1} miles";
    }
    public override string GetPace()
    {
        double pace = GetDuration() / _distance;
        int minutes = (int)pace;
        return $"Pace: {minutes:f1} min per mile";
    }

    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Running ({GetDuration()} min) - {GetDistance()}, {GetSpeed()}, {GetPace()}";
    }
}