class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime dateAndTime, string address, string rsvpEmail)
        : base(title, description, dateAndTime, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GenerateFullDetails()
    {
        return base.GenerateStandardDetails() + $"\nType: Reception\nRSVP Email: {rsvpEmail}";
    }

    public override string GenerateShortDescription()
    {
        return $"Type: Reception\nTitle: {Title}\nDate: {DateAndTime.Date}";
    }
}
