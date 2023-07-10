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

    public void RecordViewing()
    {

    }

    public void Search(List<Satellite> list)
    {
        Console.WriteLine("Enter Satellite number to search for: ");
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

    public void Save()
    {

    }

    public Satellite(int number, string dateLaunched, string name)
    {
        _number = number;
        _dateLaunched = dateLaunched;
        _name = name;
    }

    public Satellite(int number, string name)
    {
        _number = number;
        _name = name;
        _dateLaunched = "";
    }
}