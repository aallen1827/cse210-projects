public class BreathingActivity : Activity
{
    public BreathingActivity() :base()
    {
        _startMessage = "Welcome to the Breathing Activity.\nThis activity will help you relax by walking you through your breathing in and out slowly. Clear your mind and focus on your breathing.\nHow long, in seconds, would you like for your session? ";
    }

    public void BreathingInstructions()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        DisplayStart();
        Console.WriteLine("\n");
        _endTime = Timer(_time);

        while (_currentTime < _endTime)
        {
            BreatheIn();
            BreatheOut();
            _currentTime = DateTime.Now;
        }
        
        DisplayEndMessage();
    }

    public void BreatheIn()
    {
        Console.Write("Breathe in...");
        Pause();
        Console.WriteLine();
    }

    public void BreatheOut()
    {
        Console.Write("Now breathe out...");
        Pause();
        Console.WriteLine("\n");
    }
}