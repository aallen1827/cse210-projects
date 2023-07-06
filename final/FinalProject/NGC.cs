public class NGC : DeepSkyObject
{
    protected int _NGCNumber;

    public override void Display()
    {
        Console.WriteLine($"{_NGCNumber}: magnitude {_magnitude} {_objectType} ({_dateLastSeen})");
    }

    public override void RecordViewing()
    {
        
    }

    public override void Search()
    {
    
    }

    public override void Save()
    {
        
    }

    public NGC(string objectType, double magnitude, string dateLastSeen, int NGCNumber) : base(objectType, magnitude, dateLastSeen)
    {
        _NGCNumber = NGCNumber;
    }
}