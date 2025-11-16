class Scripture
{
    private Random rand = new Random();
    private List<Word> words = new List<Word>();
    private string _scripture;
    private int _shownCount;
    private Reference r;

    public Scripture(string script, string book, int chapter, int start, int end)
    {
        
        r = new Reference(book, chapter, start, end);
        _scripture=script;
        toWord();
        _shownCount=words.Count;
    }

        public Scripture(string script, string book, int chapter, int start)
    {
        r = new Reference(book, chapter, start);
        _scripture=script;
        toWord();
        _shownCount=words.Count;
    }

    private void toWord()
    {
        string[] scriptureWords = _scripture.Split(" ");
        foreach(string word in scriptureWords)
        {
            Word w = new Word(word);
            words.Add(w);
        }
    }

    public int getLength()
    {
        return words.Count();
    }

    public void Display()
    {
        r.Display();
        foreach(Word w in words)
        {
            Console.Write($"{w.Write()} ");
        }
        Console.WriteLine();
    }
    
    public void HideWords()
    {
        int i = 0;
        while (i<3)
        {
            int index=rand.Next(words.Count);
            if (!words[index].checkHidden())
            {
                words[index].Hide();
                i++;
                _shownCount--;
                if (_shownCount == 0)
                {
                    break;
                }
            }
        }
    }
}