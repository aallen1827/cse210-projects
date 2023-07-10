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

    public void Search(List<Messier> list)
    {
        Console.WriteLine("Enter Messier number to search for: ");
        int searchNumber = int.Parse(Console.ReadLine());
        bool found = false;
        while (!found)
        {
            foreach (Messier item in list) 
            {
                if (item._messierNumber == searchNumber)
                {
                    Console.Clear();
                    Console.WriteLine($"Results for Messier {searchNumber}:");
                    item.Display();
                    found = true;
                }
            }
            if (!found)
            {
                Console.Clear();
                Console.WriteLine($"Results for Messier {searchNumber}:");
                Console.WriteLine("Messier object not found");
                found = true;
            }
        }
    }

    public override void Save()
    {
        
    }

    public Messier(string objectType, double magnitude, string dateLastSeen, int NGCNumber, int messierNumber) : base(objectType, magnitude, dateLastSeen, NGCNumber)
    {
        _messierNumber = messierNumber;
    }
}