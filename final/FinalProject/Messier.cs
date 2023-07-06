public class Messier : NGC
{
    private int _messierNumber;

    public override void Display()
    {

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