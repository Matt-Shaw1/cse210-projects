public class OutdoorEvent : Event
{
    public OutdoorEvent(string title, string description, string date, string time, string address)
        : base(title, description, date, time, address)
    {
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nNote: Check wether conditions before attending anything.";
    }
}
