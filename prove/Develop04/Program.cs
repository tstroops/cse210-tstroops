using System;

class Program
{
    static void Main(string[] args)
    {
        string userIn;
        bool done=false;
        bool error=false;
        int numBreath = 0;
        int numReflect = 0;
        int numList = 0;
        do{
            Console.Clear();
            if (error)
            {
                Console.WriteLine("Your last entry was invalid. Please input a number from 1-4.");
            }
            Console.WriteLine("Menu Options:");
            Console.WriteLine($"1. Start breathing activity (completed {numBreath} times)");
            Console.WriteLine($"2. Start reflecting activity (completed {numReflect} times)");
            Console.WriteLine($"3. Start listing activity(completed {numList} times)");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            userIn = Console.ReadLine();
            if (userIn == "1")
            {
                Breathing breath=new Breathing();
                breath.RunBreathing();
                numBreath++;
            }
            else if (userIn == "2")
            {
                Reflection reflect=new Reflection();
                reflect.RunReflection();
                numReflect++;
            }
            else if (userIn == "3")
            {
                Listing list = new Listing();
                list.RunList();
                numList++;
            }
            else if (userIn == "4")
            {
                done=true;
            }
            else
            {
                error=true;
            }
        }while(!done);
    }
}