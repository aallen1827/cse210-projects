public class Messier : NGC
{
    private int _messierNumber;

    public override void Display()
    {
        Console.WriteLine($"{_messierNumber}: magnitude {_magnitude} {_objectType} (Last Seen: {_dateLastSeen})");
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

    public Messier(string objectType, double magnitude, string dateLastSeen, int NGCNumber, int messierNumber) : base(objectType, magnitude, dateLastSeen, NGCNumber)
    {
        _messierNumber = messierNumber;
    }
}