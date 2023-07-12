public class NGC : DeepSkyObject
{
    protected int _NGCNumber;

    public override void Display()
    {
        Console.WriteLine($"{_NGCNumber}: magnitude {_magnitude} {_objectType} (Last Seen: {_dateLastSeen})");
    }

    public virtual void RecordViewing(List<NGC> observedList)
    {
        Console.Write("NGC Number: ");
        int ngcNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();

        bool inList = false;

        while (!inList)
        {
            foreach (NGC ngc in observedList)
            {
                if (ngc._NGCNumber == ngcNumber)
                {
                    inList = true;

                    Console.Write("Did you see it today (y/n): ");
                    string seenToday = Console.ReadLine();
                    if (seenToday.ToLower() == "y")
                    {
                        DateTime today = DateTime.Today;
                        ngc._dateLastSeen = today.ToShortDateString();
                    }
                    else
                    {
                        Console.Write("Date Seen (mm/dd/yyyy): ");
                        string dateSeen = Console.ReadLine();
                        Console.WriteLine();
                        ngc._dateLastSeen = dateSeen;
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

            NGC newNGC = new NGC(objectType, magnitude, dateSeen, ngcNumber);
            observedList.Add(newNGC);
            Console.WriteLine("NGC object created and viewing recorded");
        }
    }

    public virtual void Search(List<NGC> list)
    {
        Console.Write("Enter NGC number to search for: ");
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

    public void Save(StreamWriter filename, List<NGC> list)
    {
        foreach (NGC ngc in list)
        {
            filename.WriteLine($"NGC,{ngc._objectType},{ngc._magnitude},{ngc._dateLastSeen},{ngc._NGCNumber}");
        }
    }

    public int GetNGCNumber()
    {
        return _NGCNumber;
    }

    public void SetDateLastSeen(string date)
    {
        _dateLastSeen = date;
    }

    public NGC(string objectType, double magnitude, string dateLastSeen, int NGCNumber) : base(objectType, magnitude, dateLastSeen)
    {
        _NGCNumber = NGCNumber;
    }
}