public class Word
{
    private string _word;
    private bool _visible;

    public Word(string word, bool visible)
    {
        _word = word;
        _visible = visible;
    }

    public void Hide(Word selectedWord)
    {
        string hiddenWord = "";

        foreach (char character in _word)
        {
            hiddenWord += "_";
        }

        selectedWord._word = hiddenWord;
        selectedWord._visible = false;
    }

    public bool IsHidden(Word word)
    {
        if (word._visible == true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    
    public string GetWord()
    {
        return _word;
    }
}