public class Caldwell : NGC
{
    private int _caldwellNumber;

    public override void Display()
    {
        Console.WriteLine($"{_caldwellNumber}: magnitude {_magnitude} {_objectType} (Last Seen: {_dateLastSeen})");
    }

    public override void RecordViewing()
    {
        
    }

    public void Search(List<Caldwell> list)
    {
        Console.WriteLine("Enter Caldwell number to search for: ");
        int searchNumber = int.Parse(Console.ReadLine());
        bool found = false;
        while (!found)
        {
            foreach (Caldwell item in list) 
            {
                if (item._caldwellNumber == searchNumber)
                {
                    Console.Clear();
                    Console.WriteLine($"Results for Caldwell {searchNumber}:");
                    item.Display();
                    found = true;
                }
            }
            if (!found)
            {
                Console.Clear();
                Console.WriteLine($"Results for Caldwell {searchNumber}:");
                Console.WriteLine("Caldwell object not found");
                found = true;
            }
        }
    }

    public override void Save()
    {
        
    }

    public Caldwell(string objectType, double magnitude, string dateLastSeen, int NGCNumber, int caldwellNumber) : base(objectType, magnitude, dateLastSeen, NGCNumber)
    {
        _caldwellNumber = caldwellNumber;
    }
}