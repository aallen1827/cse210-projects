using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        string firstString = first.GetFractionString();
        double firstDouble = first.GetDecimalValue();
        Console.WriteLine($"{firstString} {firstDouble}");

        Fraction second = new Fraction(5);
        string secondString = second.GetFractionString();
        double secondDouble = second.GetDecimalValue();
        Console.WriteLine($"{secondString} {secondDouble}");

        Fraction third = new Fraction(3, 4);
        string thirdString = third.GetFractionString();
        double thirdDouble = third.GetDecimalValue();
        Console.WriteLine($"{thirdString} {thirdDouble}");

        Fraction fourth = new Fraction(1, 3);
        string fourthString = fourth.GetFractionString();
        double fourthDouble = fourth.GetDecimalValue();
        Console.WriteLine($"{fourthString} {fourthDouble}");
    }
}