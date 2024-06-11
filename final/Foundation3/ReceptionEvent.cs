public class ReceptionEvent : Event
{
    private string EmailForRSVP { get; set; }

    public ReceptionEvent(string title, string description, string date, string time, string address, string emailForRSVP)
        : base(title, description, date, time, address)
    {
        EmailForRSVP = emailForRSVP;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP at: {EmailForRSVP}";
    }
}
