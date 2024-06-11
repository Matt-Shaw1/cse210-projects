public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }

    public ChecklistGoal(string description, int targetCount) : base(description)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
    }

    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                IsComplete = true;
            }
        }
    }
}
