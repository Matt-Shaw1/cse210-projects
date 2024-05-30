public class ReflectionActivity : Activity
{
    public ReflectionActivity(string name, string description, int duration)
        : base(name, description, duration) { }

    protected override void PerformActivity()
    {
        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult."
            // Add more prompts as needed
        };
        Random rand = new Random();
        string selectedPrompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(selectedPrompt);
        // Reflection could continue here
        DisplayCountdown(Duration); // Simulate reflection time
    }
}
