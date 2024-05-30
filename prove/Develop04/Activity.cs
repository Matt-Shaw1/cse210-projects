public abstract class Activity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Duration { get; private set; }

    public Activity(string name, string description, int duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
    }

    public void Perform()
    {
        ShowStartingMessage();
        PerformActivity();
        ShowEndingMessage();
    }

    protected virtual void PerformActivity()
    {
        // Implementation varies in derived classes
    }

    private void ShowStartingMessage()
    {
        Console.WriteLine($"Starting: {Name}");
        Console.WriteLine($"{Description}");
        Console.WriteLine("Prepare to begin...");
        DisplayCountdown(5); // 5-second preparation countdown
    }

    private void ShowEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed {Name} for {Duration} seconds.");
        DisplayCountdown(3); // 3-second closing message
    }

    protected void DisplayCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i + "...");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
