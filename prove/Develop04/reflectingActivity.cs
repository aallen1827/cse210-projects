public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() :base()
    {
        _startMessage = "Welcome to the Reflecting Activity.\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\nHow long, in seconds, would you like for your session? ";
        _prompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        _questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    }

    private string GetPrompt()
    {
        Random rand = new Random();
        int number = rand.Next(0,4);
        string selectedPrompt = _prompts[number];
        return selectedPrompt;
    }

    public void RunReflection()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        DisplayStart();
        string prompt = GetPrompt();
        Console.WriteLine($"\b \b\nConsider the following prompt:\n--- {prompt} ---\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("Now ponder each of the following questions as they are related to the experience.\nYou may begin in: ");
        Pause();
        Console.Clear();
        _endTime = Timer(_time);

        while (_currentTime < _endTime)
        {
            Random rand = new Random();
            int questionIndex = rand.Next(0, 8);
            Console.Write("> " + _questions[questionIndex]);
            Spinner(10);
            Console.WriteLine();
            _currentTime = DateTime.Now;
        }

        Console.WriteLine($"You have completed {_time} seconds of the Reflecting Activity.");
        DisplayEndMessage();
    }
}