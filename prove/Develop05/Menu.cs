using System.IO;
public class Menu
{
    public List<Goal> _goals = new List<Goal>();
    public int _totalPoints;

    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");
        int goalNumber = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{goalNumber}. ");
            goal.DisplayGoal();
            Console.WriteLine();
            goalNumber++;
        }
    }

    public int DisplayMenu()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
        Console.WriteLine($"\nMenu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\nSelect a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }

    public void Save()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetAttributes());
            }
        }
    }

    public void Load()
    {
        Console.WriteLine("What is the name of the file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string goalType = parts[0];
            
            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                int bonusPoints = int.Parse(parts[5]);
                int timesToCompletion = int.Parse(parts[6]);
                int timesCompleted = int.Parse(parts[7]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, timesToCompletion, bonusPoints, timesCompleted, isComplete);
            }
            else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal goal = new EternalGoal(name, description, points);
            }
            else
            {
                _totalPoints = int.Parse(lines[0]);
            }
        }
    }

    public Menu()
    {
        _totalPoints = 0;
    }
}