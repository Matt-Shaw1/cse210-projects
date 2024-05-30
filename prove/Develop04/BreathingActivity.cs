public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration) { }

    protected override void PerformActivity()
    {
        for (int i = 0; i < Duration / 10; i++)
        {
            Console.WriteLine("Breathe in...");
            DisplayCountdown(5);
            Console.WriteLine("Breathe out...");
            DisplayCountdown(5);
        }
    }
}
