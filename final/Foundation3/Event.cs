class Event
{
    private string title;
    private string description;
    private DateTime dateAndTime;
    private string address;

    public string Title { get => title; set => title = value; }
    public string Description { get => description; set => description = value; }
    public DateTime DateAndTime { get => dateAndTime; set => dateAndTime = value; }
    public string Address { get => address; set => address = value; }

    public Event(string title, string description, DateTime dateAndTime, string address)
    {
        Title = title;
        Description = description;
        DateAndTime = dateAndTime;
        Address = address;
    }

    public string GenerateStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate and Time: {DateAndTime}\nAddress: {Address}";
    }

    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    public virtual string GenerateShortDescription()
    {
        return $"Type: Unknown\nTitle: {Title}\nDate: {DateAndTime.Date}";
    }
}


