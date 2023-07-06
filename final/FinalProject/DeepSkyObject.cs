public abstract class DeepSkyObject : IDisplay
{
    protected string _objectType;
    protected string _dateLastSeen;
    protected double _magnitude;

    public abstract void Display();

    public abstract void RecordViewing();

    public abstract void Search();

    public abstract void Save();

    public DeepSkyObject(string objectType, double magnitude, string dateLastSeen)
    {
        _objectType = objectType;
        _magnitude = magnitude;
        _dateLastSeen = dateLastSeen;
    }
}