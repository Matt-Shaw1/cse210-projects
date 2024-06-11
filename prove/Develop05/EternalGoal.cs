public class EternalGoal : Goal
{
    public int PointsPerTime { get; set; }

    public EternalGoal(string description, int pointsPerTime) : base(description)
    {
        PointsPerTime = pointsPerTime;
    }

    public override void RecordEvent()
    {
        // Logic to add points each time the goal is recorded
    }
}
