public abstract class Goal
{
    protected int _points;
    public string _name;
    protected string _description;

    public abstract int RecordEvent();

    public abstract string GetAttributes();

    public virtual void DisplayGoal()
    {
        Console.Write($"[ ] {_name} ({_description})");
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
}