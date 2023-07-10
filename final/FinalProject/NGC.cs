public class NGC : DeepSkyObject
{
    protected int _NGCNumber;

    public override void Display()
    {
        Console.WriteLine($"{_NGCNumber}: magnitude {_magnitude} {_objectType} (Last Seen: {_dateLastSeen})");
    }

    public override void RecordViewing()
    {
        
    }

    public virtual void Search(List<NGC> list)
    {
        Console.WriteLine("Enter NGC number to search for: ");
        int searchNumber = int.Parse(Console.ReadLine());
        bool found = false;
        while (!found)
        {
            foreach (NGC item in list) 
            {
                if (item._NGCNumber == searchNumber)
                {
                    Console.Clear();
                    Console.WriteLine($"Results for NGC {searchNumber}:");
                    item.Display();
                    found = true;
                }
            }
            if (!found)
            {
                Console.Clear();
                Console.WriteLine($"Results for NGC {searchNumber}:");
                Console.WriteLine("NGC object not found");
                found = true;
            }
        }
    }

    public override void Save()
    {
        
    }

    public NGC(string objectType, double magnitude, string dateLastSeen, int NGCNumber) : base(objectType, magnitude, dateLastSeen)
    {
        _NGCNumber = NGCNumber;
    }
}