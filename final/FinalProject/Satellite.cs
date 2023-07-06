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

    public void Search()
    {

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