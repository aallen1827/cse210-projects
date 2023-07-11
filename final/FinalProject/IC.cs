public class IC : DeepSkyObject
{
    private int _ICNumber;

    public override void Display()
    {
        Console.WriteLine($"{_ICNumber}: magnitude {_magnitude} {_objectType} (Last Seen: {_dateLastSeen})");
    }

    public void RecordViewing(List<IC> observedList)
    {
        Console.Write("IC Number: ");
        int icNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();

        bool inList = false;

        while (!inList)
        {
            foreach (IC ic in observedList)
            {
                if (ic._ICNumber == icNumber)
                {
                    inList = true;

                    Console.Write("Did you see it today (y/n): ");
                    string seenToday = Console.ReadLine();
                    Console.WriteLine();
                    if (seenToday.ToLower() == "y")
                    {
                        DateTime today = DateTime.Today;
                        ic._dateLastSeen = today.ToShortDateString();
                    }
                    else
                    {
                        Console.Write("Date Seen (mm/dd/yyyy): ");
                        string dateSeen = Console.ReadLine();
                        Console.WriteLine();
                        ic._dateLastSeen = dateSeen;
                    }
                    Console.WriteLine("Viewing Recorded");
                }
            }
            break;
        }
        if (!inList)
        {
            Console.Write("Object Type: ");
            string objectType = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Magnitude: ");
            double magnitude = double.Parse(Console.ReadLine());
            Console.Write("Did you see it today (y/n): ");
            string seenToday = Console.ReadLine();
            Console.WriteLine();
            string dateSeen = "";
            if (seenToday.ToLower() == "y")
            {
                DateTime today = DateTime.Today;
                dateSeen = today.ToShortDateString();
            }
            else
            {
                Console.Write("Date Seen (mm/dd/yyyy): ");
                dateSeen = Console.ReadLine();
                Console.WriteLine();
            }

            IC newIC = new IC(objectType, magnitude, dateSeen, icNumber);
            observedList.Add(newIC);
            Console.WriteLine("IC object created and viewing recorded");
        }
    }

    public void Search(List<IC> list)
    {
        Console.Write("Enter IC number to search for: ");
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