public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string fullText)
    {
        _reference = reference;
    }

    public void Display()
    {
        Console.Clear();
        string reference = _reference.GetFullReference(_reference);
        string words = GetFullText(_words);
        Console.WriteLine($"{reference} {words}");
        Console.WriteLine($"\nPress Enter to continue or type quit to end.");
    }

    public void HideWords()
    {
        int totalWords = _words.Count;
        int runs = 3;
        int wordsLeft = 0;

        foreach (Word word in _words)
        {
            bool hidden = word.IsHidden(word);
            if (hidden == false)
            {
                wordsLeft +=1;
            }
        }

        if (wordsLeft < 3)
        {
            runs = wordsLeft;
        }

        for (int i = 0; i < runs; ++i)
        {
            bool wordHidden = true;
            Word selectedWord = new Word("", true);

            while (wordHidden == true)
            {
                Random random = new Random();
                int wordNumber = random.Next(0,totalWords);
                selectedWord = _words[wordNumber];
                wordHidden = selectedWord.IsHidden(selectedWord);
            
                if (wordHidden == false)
                {
                    selectedWord.Hide(selectedWord);
                }
            }
        }
    }

    public bool AllHidden()
    {
        int totalWords = _words.Count();
        int hiddenWords = 0;

        foreach (Word word in _words)
        {
            bool hidden = word.IsHidden(word);
            if (hidden)
            {
                hiddenWords += 1;
            }
        }
        
        if (totalWords == hiddenWords)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void CreateWords(string text)
    {
        string[] words = text.Split(' ');

        foreach (var word in words)
        {
            Word singleWord = new Word(word, true);
            _words.Add(singleWord);
        }
    }
    public string GetFullText(List<Word> _words)
    {
        string allWords = "";

        foreach (Word word in _words)
        {
            string wordText = word.GetWord();
            
            allWords += $"{wordText} ";
        }
        
        return allWords;
    }
}