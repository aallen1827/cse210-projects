using System;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        int SquareNumber(int number)
        {
            int result = number * number;
            return result;
        }

        void DisplayResult(string name, int number)
        {
            Console.Write($"{name}, the square of your number is {number}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }
}