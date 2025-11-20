class Activity
{
    protected string _startMessage;
    protected string _endMessage;
    protected string _actName;
    protected string _description;
    protected int _duration;
    protected string[] _promptBank;
    
    public Activity(string[] prompts, string start, string end, string name, string description)
    {
        _startMessage = start;
        _endMessage = end;
        _actName = name;
        _description = description;
        _promptBank = prompts;
    }
    
    public Activity(string start, string end, string name, string description)
    {
        _startMessage = start;
        _endMessage = end;
        _actName = name;
        _description = description;
    }

    public void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the {_actName} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration=int.Parse(Console.ReadLine());
    }
}