public class ListingActivity : Activity
{
    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration) { }

    protected override void PerformActivity()
    {
        Console.WriteLine("List all the good things you can think of:");
        DisplayCountdown(Duration); // Simulate time for listing
    }
}
