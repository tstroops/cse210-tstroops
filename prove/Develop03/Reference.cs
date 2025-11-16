class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }

    public Reference(string book, int chapter, int start)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = 0;
    }

    public void Display()
    {
        if (_endVerse == 0)
        {
            Console.Write($"{_book} {_chapter}:{_startVerse} ");
        }
        else
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");
        }
    }
}