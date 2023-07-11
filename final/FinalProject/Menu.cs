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
        if (_listNumber != 4)
        {
            Console.Clear();
        }
        hovering = 0;
        Display();
        bool selected = false;
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

    public void DisplayObjects(IEnumerable<IDisplay> list)
    {
        Console.Clear();
        foreach (var x in list)
        {
            x.Display();
        }
    }

    public void Save()
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