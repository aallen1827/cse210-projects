using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }
        int numberCount = 0;
        int numberTotal = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            numberTotal = number + numberTotal;
            numberCount ++;
            if (number > largest)
            {
                largest = number;
            }
        }
        int average = numberTotal / numberCount;
        Console.WriteLine($"The sum is: {numberTotal}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}