public class Satellite : IDisplay
{
    private int _number;
    private string _dateLaunched;
    private string _name;

    public void Display()
    {
        if (_dateLaunched != "")
        {
            Console.WriteLine($"{_number}: {_name} (Launched {_dateLaunched})");
        }
        else
        {
            Console.WriteLine($"{_number}: {_name}");
        }
    }

    public void RecordViewing(List<Satellite> observedList)
    {
        Console.Write("Satellite Number: ");
        int satelliteNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();

        bool inList = false;

        while (!inList)
        {
            foreach (Satellite satellite in observedList)
            {
                if (satellite._number == satelliteNumber)
                {
                    inList = true;
                    Console.Write("Already seen");
                }
            }
            break;
        }
        if (!inList)
        {
            Console.Write("Date Launched: ");
            string dateLaunched = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            Satellite newSatellite = new Satellite(satelliteNumber, dateLaunched, name);
            observedList.Add(newSatellite);
            Console.WriteLine("Satellite added");
        }
    }

    public void Search(List<Satellite> list)
    {
        Console.Write("Enter Satellite number to search for: ");
        int searchNumber = int.Parse(Console.ReadLine());
        bool found = false;
        while (!found)
        {
            foreach (Satellite item in list) 
            {
                if (item._number == searchNumber)
                {
                    Console.Clear();
                    Console.WriteLine($"Results for satellite {searchNumber}:");
                    item.Display();
                    found = true;
                }
            }
            if (!found)
            {
                Console.Clear();
                Console.WriteLine($"Results for satellite {searchNumber}:");
                Console.WriteLine("Satellite not found");
                found = true;
            }
        }
    }

    public void Save(StreamWriter filename, List<Satellite> list)
    {
        foreach (Satellite satellite in list)
        {
            filename.WriteLine($"Satellite,{satellite._number},{satellite._dateLaunched},{satellite._name}");
        }
    }

    public Satellite(int number, string dateLaunched, string name)
    {
        _number = number;
        _dateLaunched = dateLaunched;
        _name = name;
    }
}