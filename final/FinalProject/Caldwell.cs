public class Caldwell : NGC
{
    private int _caldwellNumber;

    public override void Display()
    {
        Console.WriteLine($"{_caldwellNumber}: magnitude {_magnitude} {_objectType} (Last Seen: {_dateLastSeen})");
    }

    public void RecordViewing(List<Caldwell> observedList, List<NGC> ngcList)
    {
        Console.Write("Caldwell Number: ");
        int caldwellNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();

        bool inList = false;

        while (!inList)
        {
            foreach (Caldwell caldwell in observedList)
            {
                if (caldwell._caldwellNumber == caldwellNumber)
                {
                    inList = true;
                    string dateSeen = "";

                    Console.Write("Did you see it today (y/n): ");
                    string seenToday = Console.ReadLine();
                    Console.WriteLine();
                    if (seenToday.ToLower() == "y")
                    {
                        DateTime today = DateTime.Today;
                        dateSeen = today.ToShortDateString();
                        caldwell._dateLastSeen = dateSeen;
                    }
                    else
                    {
                        Console.Write("Date Seen (mm/dd/yyyy): ");
                        dateSeen = Console.ReadLine();
                        Console.WriteLine();
                        caldwell._dateLastSeen = dateSeen;
                    }

                    foreach (NGC ngc in ngcList)
                    {
                        int NGCNumber = ngc.GetNGCNumber();
                        if (NGCNumber == caldwell._NGCNumber)
                        {
                            ngc.SetDateLastSeen(dateSeen);
                        }
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
            Console.WriteLine();
            Console.Write("NGC Number: ");
            int ngcNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
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

            Caldwell newCaldwell = new Caldwell(objectType, magnitude, dateSeen, ngcNumber, caldwellNumber);
            observedList.Add(newCaldwell);

            NGC newNGC = new NGC(objectType, magnitude, dateSeen, ngcNumber);
            ngcList.Add(newNGC);
            Console.WriteLine("Caldwell object created and viewing recorded");
        }
    }

    public void Search(List<Caldwell> list)
    {
        Console.Write("Enter Caldwell number to search for: ");
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