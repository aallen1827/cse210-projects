public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() :base()
    {
        _startMessage = "Welcome to the Listing Activity.\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\nHow long, in seconds, would you like for your session? ";
        _prompts = new List<string> {"Who are people you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    }

    public string GetPrompt()
    {
        Random rand = new Random();
        int number = rand.Next(0,4);
        string selectedPrompt = _prompts[number];
        return selectedPrompt;
    }

    public void RunListingActivity()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        string prompt = GetPrompt();
        DisplayStart();
        Console.Write($"\b \b\nList as many responses as you can to the following prompt:\n--- {prompt} ---\nYou may begin in: ");
        Pause();
        Console.WriteLine();
        _endTime = Timer(_time);
        int entries = 0;

        while (_currentTime < _endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            entries++;
            _currentTime = DateTime.Now;
        }
        
        Console.WriteLine($"You listed {entries} items!");
        DisplayEndMessage();
    }
}