public class NonNGC : DeepSkyObject
{
    private string _catalogue;
    private int _number;

    public override void Display()
    {
        Console.WriteLine($"{_catalogue} {_number}: magnitude {_magnitude} {_objectType} ({_dateLastSeen})");
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

    public NonNGC(string objectType, double magnitude, string dateLastSeen, string catalogue, int number) : base(objectType, magnitude, dateLastSeen)
    {
        _catalogue = catalogue;
        _number = number;
    }
}