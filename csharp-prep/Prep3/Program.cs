using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumberGenerator = new Random();
        
        int targetNumber = randomNumberGenerator.Next(1, 101);

        int currentGuess = -1; 

        while (currentGuess != targetNumber)
        {
            Console.Write("What is your guess? ");
            currentGuess = int.Parse(Console.ReadLine()); 

            if (currentGuess < targetNumber)
            {Console.WriteLine("Higher");}
            else if (currentGuess > targetNumber)
            {Console.WriteLine("Lower");}
            else
            {Console.WriteLine("You got it!");}
        }                    
    }
}
