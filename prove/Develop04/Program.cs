using System;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an activity (1-Breathing, 2-Reflection, 3-Listing, 4-View Log, 5-Exit):");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid option, please try again.");
                    continue;
                }

                if (choice == 5)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                Activity activity = null;
                switch (choice)
                {
                    case 1:
                        activity = new BreathingActivity("Breathing", "Relaxing breath control.", 60);
                        break;
                    case 2:
                        activity = new ReflectionActivity("Reflection", "Deep thinking about past achievements.", 60);
                        break;
                    case 3:
                        activity = new ListingActivity("Listing", "Enumerate positive aspects.", 60);
                        break;
                    case 4:
                        Logger.ShowLog();
                        continue;
                }

                activity?.Perform();
                Logger.LogActivity(activity.Name, activity.Duration);
            }
        }
    }
}
