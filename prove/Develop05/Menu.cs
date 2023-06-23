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
        Console.Write($"\nMenu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\nSelect a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }

    public void Save()
    {
        Console.Write("What is the filename? ");
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
        Console.Write("What is the name of the file? ");
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
                _goals.Add(goal);
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
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }

            else if (goalType == "NegativeGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                NegativeGoal goal = new NegativeGoal(name, description, points);
                _goals.Add(goal);
            }
            
            else
            {
                _totalPoints = int.Parse(lines[0]);
            }
        }
    }

    public void CreateGoal()
    {
        Console.Write("The types of goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\n 4. Negative Goal\nWhat type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of the goal? ");
        string description = Console.ReadLine();

        if (choice == 1)
        {
            Console.Write("What is the amount of points associated with the goal? ");
            int points = int.Parse(Console.ReadLine());
            
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (choice == 2)
        {
            Console.Write("What is the amount of points associated with the goal? ");
            int points = int.Parse(Console.ReadLine());
            
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (choice == 3)
        {
            Console.Write("What is the amount of points associated with the goal? ");
            int points = int.Parse(Console.ReadLine());
            
            Console.Write("How many times does the goal need to be completed for a bonus? ");
            int timesToCompletion = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for completing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, description, points, timesToCompletion, bonusPoints);
            _goals.Add(goal);
        }
        else
        {
            Console.Write("How many points should you lose for doing this? ");
            int points = int.Parse(Console.ReadLine());
            
            int negativePoints = -points;
            NegativeGoal goal = new NegativeGoal(name, description, negativePoints);
            _goals.Add(goal);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        int goalNumber = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goalNumber}. {goal._name}");
            goalNumber++;
        }
        Console.Write("Which goal did you accomplish? ");
        int goalCompletedNumber = int.Parse(Console.ReadLine());
        Goal completedGoal = _goals[(goalCompletedNumber - 1)];
        int points = completedGoal.RecordEvent();
        _totalPoints += points;
    }

    public Menu()
    {
        _totalPoints = 0;
    }
}