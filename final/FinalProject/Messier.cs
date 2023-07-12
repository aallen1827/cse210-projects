public class Messier : NGC
{
    private int _messierNumber;

    public override void Display()
    {
        Console.WriteLine($"{_messierNumber}: magnitude {_magnitude} {_objectType} (Last Seen: {_dateLastSeen})");
    }

    public void RecordViewing(List<Messier> observedList, List<NGC> ngcList)
    {
        Console.Write("Messier Number: ");
        int messierNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();

        bool inList = false;

        while (!inList)
        {
            foreach (Messier messier in observedList)
            {
                if (messier._messierNumber == messierNumber)
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
                        messier._dateLastSeen = dateSeen;
                    }
                    else
                    {
                        Console.Write("Date Seen (mm/dd/yyyy): ");
                        dateSeen = Console.ReadLine();
                        Console.WriteLine();
                        messier._dateLastSeen = dateSeen;
                    }

                    foreach (NGC ngc in ngcList)
                    {
                        int NGCNumber = ngc.GetNGCNumber();
                        if (NGCNumber == messier._NGCNumber)
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

            Messier newMessier = new Messier(objectType, magnitude, dateSeen, ngcNumber, messierNumber);
            observedList.Add(newMessier);

            NGC newNGC = new NGC(objectType, magnitude, dateSeen, ngcNumber);
            ngcList.Add(newNGC);

            Console.WriteLine("Messier object created and viewing recorded");
        }
    }

    public void Search(List<Messier> list)
    {
        Console.Write("Enter Messier number to search for: ");
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

    public void Save(StreamWriter filename, List<Messier> list)
    {
        foreach (Messier messier in list)
        {
            filename.WriteLine($"Messier,{messier._objectType},{messier._magnitude},{messier._dateLastSeen},{messier._NGCNumber},{messier._messierNumber}");
        }

    }

    public Messier(string objectType, double magnitude, string dateLastSeen, int NGCNumber, int messierNumber) : base(objectType, magnitude, dateLastSeen, NGCNumber)
    {
        _messierNumber = messierNumber;
    }
}