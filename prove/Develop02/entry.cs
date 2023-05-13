public class Entry
{
    public List<Entry> _entries = new List<Entry>();
    public string _date;
    public string _journalEntry;
    public string _prompt;
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - {_prompt}\n{_journalEntry}");
    }
}