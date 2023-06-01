public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public string GetHomeworkList()
    {
        string summary = GetSummary();
        string homeworkList = $"{summary}\r\nSection {_textbookSection} Problems {_problems}";
        return homeworkList;
    }

    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }
}