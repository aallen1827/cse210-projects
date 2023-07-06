public class Caldwell : NGC
{
    private int _caldwellNumber;

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

    public Caldwell(string objectType, double magnitude, string dateLastSeen, int NGCNumber, int caldwellNumber) : base(objectType, magnitude, dateLastSeen, NGCNumber)
    {
        _caldwellNumber = caldwellNumber;
    }
}