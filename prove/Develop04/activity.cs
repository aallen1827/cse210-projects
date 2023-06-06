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
        _startMessage = "startMessage";
        _endMessage = "endMessage";
    }
    public void Pause()
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
    public void Spinner(int time)
    {
        _time = time;
        Timer();
        while (_currentTime < _endTime)
        {
            Console.Write("-");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            _currentTime = DateTime.Now;
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            _currentTime = DateTime.Now;
        }
    }

    public void Timer()
    {
        DateTime startTime = DateTime.Now;
        _endTime = startTime.AddSeconds(_time);
        _currentTime = DateTime.Now;
    }
}