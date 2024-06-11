using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity("03 Nov 2022", 30, 3.0), 
            new CyclingActivity("03 Nov 2022", 45, 15.0),
            new SwimmingActivity("03 Nov 2022", 30, 12)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
