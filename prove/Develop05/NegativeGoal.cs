public class NegativeGoal : Goal
{
    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetAttributes()
    {
        string attributes = $"NegativeGoal,{_name},{_description},{_points}";
        return attributes;
    }

    public override void DisplayGoal()
    {
        Console.Write($"[ ] {_name} ({_description}) -- Negative Goal");
    }

    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {

    }
}