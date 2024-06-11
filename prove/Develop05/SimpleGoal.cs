public class SimpleGoal : Goal
{
    public int PointsValue { get; set; }

    public SimpleGoal(string description, int pointsValue) : base(description)
    {
        PointsValue = pointsValue;
    }

    public override void RecordEvent()
    {
        // Add logic to record event and update points
        IsComplete = true;
    }
}
