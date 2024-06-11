using System;

class Program
{
    static void Main()
    {
        Event lecture = new LectureEvent("C# Fiesta", "Deep dive into the rich exciting history of c#", "2024-06-15", "10:00 AM", "123 Learning St", "Professor Smith", 100);
        Event reception = new ReceptionEvent("Meet and Greet", "Meet the best and the brightest minds on this", "2024-06-20", "06:00 PM", "111 EventReception Lane", "events@gmail.com");
        Event outdoor = new OutdoorEvent("Park Cleanup", "Cleaning activity for people needing service", "2024-06-22", "08:00 AM", "789 Clean Park Ave");

        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(outdoor.GetFullDetails());
    }
}
