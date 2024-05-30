using System;
using System.IO;

public static class Logger
{
    // Define the correct full path for the log file
    private static string logFilePath = @"C:\Users\12085\Desktop\cse210-projects\prove\Develop04\MindfulnessLog.txt";

    public static void LogActivity(string activityName, int duration)
    {
        // Log the activity with a timestamp.
        string logEntry = $"{DateTime.Now}: Completed {activityName} for {duration} seconds.";
        // Append this log entry to the log file.
        File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
    }

    public static void ShowLog()
    {
        if (File.Exists(logFilePath))
        {
            Console.WriteLine("Activity Log:");
            // Read all log entries and display them.
            string[] logEntries = File.ReadAllLines(logFilePath);
            foreach (string entry in logEntries)
            {
                Console.WriteLine(entry);
            }
        }
        else
        {
            Console.WriteLine("No activities logged yet.");
        }
    }
}
