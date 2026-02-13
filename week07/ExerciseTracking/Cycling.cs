class Cycling : Activity
{
    private double _speed;
    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override string GetSpeed()
    {
        return $"Speed: {_speed:f1} mph";
    }
    public override string GetDistance()
    {
        double distance = _speed * GetDuration() / 60.0;
        return $"Distance: {distance:f1} miles";
    }
    public override string GetPace()
    {
        double distance = _speed * GetDuration() / 60.0;
        double pace = GetDuration() / distance  ;
        int minutes = (int)pace;
        int seconds = (int)((pace - minutes) * 60);
        return $"Pace: {minutes:f1} min per mile";
    }

    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Cycling ({GetDuration()} min.) - {GetDistance()}, {GetSpeed()}, {GetPace()}";
    }
}