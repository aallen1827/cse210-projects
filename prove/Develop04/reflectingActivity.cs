public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    public ReflectingActivity() :base()
    {
        _startMessage = "Welcome to the Reflecting Activity.\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\nHow long, in seconds, would you like for your session? ";
    }

    public string GetPrompt()
    {
        Random rand = new Random();
        int number = rand.Next(0,4);
        string selectedPrompt = _prompts[number];
        return selectedPrompt;
    }
}