using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";

        Console.Write("What is your grade? ");
        int numberGrade = int.Parse(Console.ReadLine());
        if (numberGrade >= 90)
        {
            letter = "A";
        }
        else if (numberGrade >= 80 && numberGrade < 90)
        {
            letter = "B";
        }
        else if (numberGrade >= 70 && numberGrade < 80)
        {
            letter = "C";
        }
        else if (numberGrade >= 60 && numberGrade < 70)
        {
            letter = "D";
        }
        else if (numberGrade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"You got a {letter}.");

        if (numberGrade >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class. Keep trying.");
        }
    }
}