class Reflection : Activity
{
    private string[] _responseBank = [
        "What skills or insights did you gain?",
        "How can you apply what you learned from the experience to future situations?",
        "What would you improve the next time I face this situation?",
        "What was your strongest emotion from the experience?",
        "What surprised you the most about the experience?",
        "What challenges did you face, and how did you overcome them?",
        "Does that experience remind you of other ones like it?",
        "How did the experience affect your confidence and motivation?",
        "What motivated you to take that course of action?"
    ];
    public Reflection()
    {
        _actName="Reflection";
        _description="This activity will help you reflect on a positive experience in your life. It will help you recognize and apply what you've learned to future situations.";
        _promptBank = [
            "Think of a time when you overcame something that scared you.",
            "Think of a time when you effectively handled a conflict in your life.",
            "Think of a time when you served another at no benefit to yourself.",
            "Think of a time when you overcame a difficult personal challenge."
        ];
    }
    public void RunReflection()
    {
        DisplayWelcome();

        Console.WriteLine("Consider the following prompt...");
        Console.WriteLine();
        Console.WriteLine(_promptBank[rand.Next(_promptBank.Length)]);
        Console.WriteLine();
        Console.WriteLine("Press enter to continue when you have an experience in mind.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.Write("You may begin in...");
        Animation(5,true);
        Console.WriteLine();

        getEndTime();

        while (_current < _stopTime)
        {
            Console.WriteLine(_responseBank[rand.Next(_responseBank.Length)]);
            Animation(10,false);
            _current=DateTime.Now;
        }

        Console.Write("\b");
        DisplayEnd();
    }
}