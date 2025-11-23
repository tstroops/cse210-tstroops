class Listing :Activity
{
    private int _numItems;
    public Listing()
    {
        _numItems=0;
        _promptBank=[
            "Who are your role models?",
            "What do you value most?",
            "When have you felt peaceful this last week?",
            "What are your best qualities?",
            "How have I improved since last year?"
        ];
        _description = "This activity will help focus on the positives of your life by having you list items about a certain topic.";
        _actName="Listing";
    }
    public void RunList()
    {
        DisplayWelcome();
        Console.WriteLine();
        Console.WriteLine(_promptBank[rand.Next(_promptBank.Length)]);
        Console.Write("You may begin in... ");
        Animation(5,true);
        Console.WriteLine();

        getEndTime();
        while (_current < _stopTime)
        {
            Console.ReadLine();
            _numItems++;
            _current=DateTime.Now;
        }
        
        Console.WriteLine($"You listed {_numItems} items.");
        DisplayEnd();
    }
}