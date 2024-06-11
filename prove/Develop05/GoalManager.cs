using System.Collections.Generic;

public class GoalManager
{
    public List<Goal> Goals { get; set; } = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }
}
