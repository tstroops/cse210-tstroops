using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

class Activity
{
    protected string _actName;
    protected string _description;
    protected int _duration;
    protected string[] _promptBank;
    protected DateTime _current;
    protected DateTime _stopTime;
    protected Random rand = new Random();

    protected void DisplayWelcome()
    {
        bool done = false;
        bool valid = true;
        while (!done){
            Console.Clear();
            if (!valid)
            {
                Console.WriteLine("That is not a valid duration.");
                valid=true;
            }
            Console.WriteLine($"Welcome to the {_actName} Activity");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            _duration=int.Parse(Console.ReadLine());
            if (_duration <= 0)
            {
                valid=false;
            }
            else
            {
                done=true;
            }
        }
        Console.Clear();
        Console.Write("Get Ready ");
        Animation(3, true);
        Console.Write("\n");
    }
    protected void Animation(int duration, bool useNum)
    {
        DateTime current = DateTime.Now;
        DateTime stopTime = current.AddSeconds(duration);
        Console.CursorVisible=false;
        if (useNum)
        {
            while(current<stopTime)
            {
            current=DateTime.Now;
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b");
            duration--;
            }
        }
        else
        {
            int i = 0;
            string ani = "|/-\\";
            while (current < stopTime)
            {
            current=DateTime.Now;
            Console.Write(ani.Substring(i%4,1));
            Thread.Sleep(125);
            Console.Write("\b");
            i++;
            }
        }
        Console.CursorVisible=true;
        Console.Write(" ");
    }
    protected void DisplayEnd()
    {
        Console.WriteLine("Well done!");
        Animation(3,false);
        Console.WriteLine();
        Console.WriteLine($"You've completed {_duration} seconds of the {_actName} activity.");
        Animation(3, false);
    }

    protected void getEndTime()
    {
        _current=DateTime.Now;
        _stopTime=_current.AddSeconds(_duration);
    }
}