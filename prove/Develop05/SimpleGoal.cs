public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public override int RecordEvent()
    {
        _isCompleted = true;
        return _points;
    }

    public override void DisplayGoal()
    {
        if (_isCompleted)
        {
            Console.Write($"[x] {_name} ({_description})");
        }
        else
        {
            Console.Write($"[ ] {_name} ({_description})");
        }
    }

    public override string GetAttributes()
    {
        string attributes = $"SimpleGoal,{_name},{_description},{_points},{_isCompleted}";
        return attributes;
    }

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isCompleted = isComplete;
    }
}