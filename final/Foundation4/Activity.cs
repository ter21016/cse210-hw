class Activity
{
    private DateTime date;
    private int durationInMinutes;

    public DateTime Date { get => date; set => date = value; }
    public int DurationInMinutes { get => durationInMinutes; set => durationInMinutes = value; }

    public Activity(DateTime date, int durationInMinutes)
    {
        Date = date;
        DurationInMinutes = durationInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default implementation for activities without distance tracking
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation for activities without speed tracking
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation for activities without pace tracking
    }

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({DurationInMinutes} min)";
    }
}

