public class Activity
{
    protected string _name;
    protected string _startMessage;
    protected string _endMessage;
    protected int _time;
    protected DateTime _endTime;
    protected DateTime _currentTime;


    public Activity()
    {
        _endMessage = "Well done!";
    }

    protected void Pause()
    {
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

    protected void Spinner(int time)
    {
        DateTime endTime = Timer(time);

        while (_currentTime < endTime)
        {
            Console.Write("-");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(400);
            Console.Write("\b \b");
            _currentTime = DateTime.Now;
            Console.Write("|");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(400);
            Console.Write("\b \b");
            _currentTime = DateTime.Now;
        }
    }

    protected DateTime Timer(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        _currentTime = DateTime.Now;
        return endTime;
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine(_endMessage);
        Spinner(3);
        Console.ResetColor();
    }

    protected void DisplayStart()
    {
        Console.Clear();
        Console.Write(_startMessage);
        _time = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);
    }
}