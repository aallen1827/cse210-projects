public class Menu
{
    private int _entryNumbers;
    private List<string> _entries;
    private string _message;
    private int hovering;
    public int _listNumber;

    public void Display()
    {
        int index = 0;
        Console.WriteLine(_message);
        foreach (string entry in _entries)
        {
            if (hovering == index)
            {
                Console.WriteLine($"[x] {entry}");
            }
            else
            {
                Console.WriteLine($"[ ] {entry}");
            }
            index++;
        }
    }
    public int Selection()
    {
        Console.Clear();
        Display();
        bool selected = false;
        hovering = 0;
        while (!selected)
        {
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            if (keyPressed.Key == ConsoleKey.Enter)
            {
                selected = true;
            }
            else if (keyPressed.Key == ConsoleKey.UpArrow)
            {
                if (hovering > 0)
                {
                    hovering = hovering -1;
                }
                Console.Clear();
                Display();
            }
            else if (keyPressed.Key == ConsoleKey.DownArrow)
            {
                if (hovering < (_entryNumbers - 1))
                {
                    hovering++;
                }
                Console.Clear();
                Display();
            }
        }
        return hovering;
    }
    public void Search(string filename)
    {
        Console.Clear();
        Console.WriteLine("Search: ");
        int searchNumber = int.Parse(Console.ReadLine());
        string[] lines = System.IO.File.ReadAllLines(filename);
        Console.Clear();
        foreach (string line in lines)
        {
            if (searchNumber == int.Parse(line))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ResetColor();
            }
            Console.WriteLine(line);
        }
    }

    public void DisplayObjects(string catalogue)
    {
        if (catalogue == "NGC")
        {
            //foreach (NGC ngc in )
            {
               // ngc.Display();
            }
        }
        else if (catalogue == "IC")
        {

        }
        else if (catalogue == "NonNGC")
        {

        }
        else if (catalogue == "Messier")
        {

        }
        else if (catalogue == "Caldwell")
        {

        }
        else
        {

        }
    }

    public void Save()
    {

    }

    public void RecordViewing()
    {

    }

    public Menu(List<string> entries, string message, int listNumber)
    {
        _entries = entries;
        _entryNumbers = _entries.Count();
        hovering = 0;
        _message = message;
        _listNumber = listNumber;
    }
}