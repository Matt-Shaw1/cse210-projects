using System;

public class UIManager
{
    private GoalManager goalManager = new GoalManager();

    public void MainMenu()
    {
        // Logic for main menu: create goals, record events, view goals, etc.
    }

    public void DisplayGoals()
    {
        foreach (var goal in goalManager.Goals)
        {
            Console.WriteLine(goal.Description + (goal.IsComplete ? " [X]" : " [ ]"));
        }
    }
}
