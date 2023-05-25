public class Reference
{
    private string _book;
    private string _chapter;
    private string _verses;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verses = verse;
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verses = $"{startVerse}-{endVerse}";
    }

    public string GetFullReference(Reference reference)
    {
        string fullReference = $"{_book} {_chapter}:{_verses}";
        
        return fullReference;
    }
}