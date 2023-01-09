using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1, 100); 
        int guess = -1; 

    while (random != guess)
    {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (guess > random)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < random)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
    }
}