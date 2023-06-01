public class WritingAssignment : Assignment
{
    private string _title;

    public string GetWritingInformation()
    {
        string summary = GetSummary();
        string writingInformation = $"{summary}\r\n{_title} by {_studentName}";
        return writingInformation;
    }

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
}