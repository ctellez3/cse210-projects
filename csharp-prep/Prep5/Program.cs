using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            double squaredNumber = Math.Pow(number, 2); 
            Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        }
    }
}