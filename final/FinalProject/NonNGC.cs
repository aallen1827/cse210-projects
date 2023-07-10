public class NonNGC : DeepSkyObject
{
    private string _catalogue;
    private int _number;

    public override void Display()
    {
        Console.WriteLine($"{_catalogue} {_number}: magnitude {_magnitude} {_objectType} (Last Seen: {_dateLastSeen})");
    }

    public override void RecordViewing()
    {
        
    }

    public void Search(List<NonNGC> list)
    {
        Console.WriteLine("Enter catalogue to search in: ");
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