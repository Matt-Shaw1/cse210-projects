public abstract class Goal
{
    public string Description { get; set; }
    public bool IsComplete { get; set; }

    public Goal(string description)
    {
        Description = description;
        IsComplete = false;
    }

    public abstract void RecordEvent();
}
