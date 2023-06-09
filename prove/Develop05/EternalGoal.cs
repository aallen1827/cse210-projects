public class EternalGoal : Goal
{
    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetAttributes()
    {
        string attributes = $"EternalGoal,{_name},{_description},{_points}";
        return attributes;
    }
    
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
}