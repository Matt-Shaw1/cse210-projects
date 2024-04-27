using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";
        string sign = "";

        if (grade >= 90)
            letter = "A";
        else if (grade >= 80)
            letter = "B";
        else if (grade >= 70)
            letter = "C";
        else if (grade >= 60)
            letter = "D";
        else
            letter = "F";

        int lastDigit = grade % 10;

        if (letter != "F")
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
        }

        if (letter == "A" && sign == "+")
            sign = "";  
        Console.WriteLine($"Your letter grade is {letter}{sign}.");

        if (grade >= 70)
            Console.WriteLine("Congratulations! You passed the course.");
        else
            Console.WriteLine("You did not pass");
    }
}
