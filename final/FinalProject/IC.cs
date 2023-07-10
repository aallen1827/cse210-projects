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

    public void Search(List<IC> list)
    {
        Console.WriteLine("Enter IC number to search for: ");
        int searchNumber = int.Parse(Console.ReadLine());
        bool found = false;
        while (!found)
        {
            foreach (IC item in list) 
            {
                if (item._ICNumber == searchNumber)
                {
                    Console.Clear();
                    Console.WriteLine($"Results for IC {searchNumber}:");
                    item.Display();
                    found = true;
                }
            }
            if (!found)
            {
                Console.Clear();
                Console.WriteLine($"Results for IC {searchNumber}:");
                Console.WriteLine("IC object not found");
                found = true;
            }
        }
    }

    public override void Save()
    {
        
    }

    public IC(string objectType, double magnitude, string dateLastSeen, int ICNumber) : base(objectType, magnitude, dateLastSeen)
    {
        _ICNumber = ICNumber;
    }
}