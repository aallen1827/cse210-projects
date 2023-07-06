public class IC : DeepSkyObject
{
    private int _ICNumber;

    public override void Display()
    {
        Console.WriteLine($"{_ICNumber}: magnitude {_magnitude} {_objectType} (Last Seen: {_dateLastSeen})");
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

    public IC(string objectType, double magnitude, string dateLastSeen, int ICNumber) : base(objectType, magnitude, dateLastSeen)
    {
        _ICNumber = ICNumber;
    }
}