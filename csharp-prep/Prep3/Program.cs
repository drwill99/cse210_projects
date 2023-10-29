using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        
        int guess;
        int guesses = 0;
        guess = 0; 
        
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guessText = Console.ReadLine();
            guess = int.Parse(guessText);
            guesses += 1;

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You got it!");
                Console.WriteLine($"It took you {guesses} guesses.");
            }
        }

    }
}