class Cycling : Activity
{
    private double distance; // in miles

    public double Distance { get => distance; set => distance = value; }

    public Cycling(DateTime date, int durationInMinutes, double distance)
        : base(date, durationInMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / DurationInMinutes * 30; // mph
    }

    public override double GetPace()
    {
        return 60 / GetSpeed(); // min/mile
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}
