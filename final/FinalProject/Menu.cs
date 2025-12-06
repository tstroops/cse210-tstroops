class Menu
{
    protected string[] _options;
    public Menu(string[] options)
    {
        _options=options;
    }
    public void Display()
    {
        foreach(string option in _options)
        {
            Console.WriteLine(option);
        }
    }
}