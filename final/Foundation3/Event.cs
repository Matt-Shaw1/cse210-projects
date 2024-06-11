public abstract class Event
{
    protected string Title { get; set; }
    protected string Description { get; set; }
    protected string Date { get; set; }
    protected string Time { get; set; }
    protected string Address { get; set; }

    protected Event(string title, string description, string date, string time, string address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public string GetStandardDetails()
    {
        return $"{Title} on {Date} at {Time} at {Address}\nDescription: {Description}";
    }

    public string GetShortDescription()
    {
        return $"{Title} on {Date}";
    }

    public abstract string GetFullDetails();
}
