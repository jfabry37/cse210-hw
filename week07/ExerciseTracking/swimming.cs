class Swimming : Activity
{
    private int _laps;
    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override string GetSpeed()
    {
        double distance = _laps * 50 / 1000.0;
        double speed = distance / (GetDuration() / 60.0);
        return $"Speed {speed:f1} mph";
    }

    public override string GetDistance()
    {
        double distance = _laps * 50 / 1000.0;
        return $"Distance {distance:f1} mile";
    }

    public override string GetPace()
    {
        double distance = _laps * 50 / 1000.0;
        double pace = GetDuration() / distance;
        int minutes = (int)pace;
        int seconds = (int)((pace - minutes) * 60);
        return $"Pace: {minutes:f1} minutes per mile";
    }

    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Swimming ({GetDuration()} min) - {GetDistance()}, {GetSpeed()}, {GetPace()}";
    }
}