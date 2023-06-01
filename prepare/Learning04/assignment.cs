public class Assignment
{
    protected string _studentName;
    private string _topic;

    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
}