using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = -1; 
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine(); 
            newNumber = int.Parse(answer);
        
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;    
        }

        Console.WriteLine($"The sum is: {sum}");

        double avg = Queryable.Average(numbers.AsQueryable());
        Console.WriteLine($"The average is: {avg}");

        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}