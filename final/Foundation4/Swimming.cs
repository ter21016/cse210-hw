class Swimming : Activity
{
    private int laps;

    public int Laps { get => laps; set => laps = value; }

    public Swimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000; // km
    }

    public override double GetSpeed()
    {
        return GetDistance() / DurationInMinutes * 75; // km/h
    }

    public override double GetPace()
    {
        return 60 / GetSpeed(); // min/km
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km";
    }
}

    