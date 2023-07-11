public class NonNGC : DeepSkyObject
{
    private string _catalogue;
    private int _number;

    public override void Display()
    {
        Console.WriteLine($"{_catalogue} {_number}: magnitude {_magnitude} {_objectType} (Last Seen: {_dateLastSeen})");
    }

    public virtual void RecordViewing(List<NonNGC> observedList)
    {
        Console.Write("Catalogue: ");
        string catalogue = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine();

        bool inList = false;

        while (!inList)
        {
            foreach (NonNGC nonNGC in observedList)
            {
                if (nonNGC._catalogue == catalogue)
                {
                    if (nonNGC._number == number)
                    {
                        inList = true;

                        Console.Write("Did you see it today (y/n): ");
                        string seenToday = Console.ReadLine();
                        Console.WriteLine();
                        if (seenToday.ToLower() == "y")
                        {
                            DateTime today = DateTime.Today;
                            nonNGC._dateLastSeen = today.ToShortDateString();
                        }
                        else
                        {
                            Console.Write("Date Seen (mm/dd/yyyy): ");
                            string dateSeen = Console.ReadLine();
                            Console.WriteLine();
                            nonNGC._dateLastSeen = dateSeen;
                        }
                    }
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

            NonNGC newNonNGC = new NonNGC(objectType, magnitude, dateSeen, catalogue, number);
            observedList.Add(newNonNGC);
        }
    }

    public void Search(List<NonNGC> list)
    {
        Console.Write("Enter catalogue to search in: ");
        string searchCatalogue = Console.ReadLine();
        bool found = false;
        while (!found)
        {
            foreach (NonNGC item in list) 
            {
                if (item._catalogue.ToLower() == searchCatalogue.ToLower())
                {
                    Console.WriteLine($"Enter {searchCatalogue} number to search for: ");
                    int searchNumber = int.Parse(Console.ReadLine());
                    bool numberFound = false;
                    while (!found)
                    {
                        foreach (NonNGC catalogueItem in list) 
                        {
                            if (catalogueItem._number == searchNumber)
                            {
                                Console.Clear();
                                Console.WriteLine($"Results for {searchCatalogue} {searchNumber}:");
                                catalogueItem.Display();
                                numberFound = true;
                                found = true;
                            }
                        }
                        if (!numberFound)
                        {
                            Console.Clear();
                            Console.WriteLine($"Results for {searchCatalogue} {searchNumber}:");
                            Console.WriteLine($"{searchCatalogue} object not found");
                            numberFound = true;
                            found = true;
                        }
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Catalogue not found");
                found = true;
            }
        }
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