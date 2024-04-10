class OutdoorGathering : Event
{
    public OutdoorGathering(string title, string description, DateTime dateAndTime, string address)
        : base(title, description, dateAndTime, address)
    {
    }

    public override string GenerateFullDetails()
    {
        return base.GenerateStandardDetails() + "\nType: Outdoor Gathering\nWeather: Check the forecast for updates";
    }

    public override string GenerateShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {Title}\nDate: {DateAndTime.Date}";
    }
}