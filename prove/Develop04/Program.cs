using System;

class Program
{
    static void Main(string[] args)
    {
        string userIn;
        bool done=false;
        bool error=false;
        do{
            Console.Clear();
            if (error)
            {
                Console.WriteLine("Your last entry was invalid. Please input a number from 1-4.");
            }
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            userIn = Console.ReadLine();
            if (userIn == "1")
            {
                Activity act=new Activity("","","","");
            }
            else if (userIn == "2")
            {
                continue;
            }
            else if (userIn == "3")
            {
                continue;
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