class Lecture : Event
{
    private string speakerName;
    private int capacity;

    public Lecture(string title, string description, DateTime dateAndTime, string address, string speakerName, int capacity)
        : base(title, description, dateAndTime, address)
    {
        this.speakerName = speakerName;
        this.capacity = capacity;
    }

    public override string GenerateFullDetails()
    {
        return base.GenerateStandardDetails() + $"\nType: Lecture\nSpeaker: {speakerName}\nCapacity: {capacity} attendees";
    }

    public override string GenerateShortDescription() => $"Type: Lecture\nTitle: {Title}\nDate: {DateAndTime.Date}";
}
