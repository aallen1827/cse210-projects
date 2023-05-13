public class Prompt
{
    public string _prompt;

    public List<Prompt> _prompts = new List<Prompt>();
    
    public string GeneratePrompt()
    {
        Random rnd = new Random();
        int promptNumber = rnd.Next(0, 4);
        string selectedPrompt = _prompts[promptNumber]._prompt;
        Console.WriteLine(selectedPrompt);
        return selectedPrompt;
    }
}