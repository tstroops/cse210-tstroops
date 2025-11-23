class Breathing : Activity
{
    public Breathing()
    {
        _description="This activity will help you relax through slow, controlled breathing. Let your worries go and focus on your breathing.";
        _actName="Breathing";
    }
    public void RunBreathing()
    {
        DisplayWelcome();
        
        getEndTime();

        while (_current < _stopTime)
        {
            Console.Write("Breath in... ");
            Animation(4,true);
            Console.WriteLine();
            Console.Write("Breath out... ");
            Animation(6, true);
            Console.WriteLine();
            Console.WriteLine();
            _current=DateTime.Now;
        }
        
        DisplayEnd();
        Console.Clear();
    }
}