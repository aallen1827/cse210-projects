public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _timesToComplete;
    private bool _isCompleted;
    private int _bonusPoints;

    public override int RecordEvent()
    {
        return 0;
    }

    public override void DisplayGoal()
    {
        IsComplete();
        if (_isCompleted)
        {
            Console.Write($"[x] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_timesToComplete}");
        }
        else
        {
            Console.Write($"[ ] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_timesToComplete}");
        }
    }

    private void IsComplete()
    {
        if (_timesCompleted >= _timesToComplete)
        {
            _isCompleted = true;
        }
    }

    public override string GetAttributes()
    {
        string attributes = $"ChecklistGoal,{_name},{_description},{_points},{_isCompleted},{_bonusPoints},{_timesToComplete},{_timesCompleted}";
        return attributes;
    }

    public ChecklistGoal(string name, string description, int points, int timesToCompletion, int bonusPoints) : base(name, description, points)
    {
        _timesToComplete = timesToCompletion;
        _bonusPoints = bonusPoints;
        _timesCompleted = 0;
        _isCompleted = false;
    }

    public ChecklistGoal(string name, string description, int points, int timesToCompletion, int bonusPoints, int timesCompleted, bool isComplete) : base(name, description, points)
    {
        _timesToComplete = timesToCompletion;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
        _isCompleted = isComplete;
    }
}