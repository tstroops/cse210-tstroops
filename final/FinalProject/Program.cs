using System;

class Program
{
    static void Main(string[] args)
    {
        bool done=false;
        bool doneFighting;
        string userIn;
        
        string[] menuOptions = [
            "Do you...",
            "1. Go To Combat",
            "2. Level Up",
            "3. Manage Inventory",
            "4. Quit",
            ""
        ];
        string[] combatOptions = [
            "Do you...",
            "1. Fight A Monster",
            "2. Go Back To The Charater Screen",
            "3. Quit",
            ""
        ];

        Enemy[] enemies = [];

        Menu charMenu = new Menu(menuOptions);
        Combat combatMenu = new Combat(combatOptions, enemies);
        while (!done)
        {
            doneFighting=false;
            charMenu.Display();
            Console.Write("Select an option from the menu: ");
            userIn=Console.ReadLine();
            if (userIn == "1")
            {
                Console.Clear();
                while(!doneFighting)
                {
                    combatMenu.Display();
                    Console.Write("Select an option from the menu: ");
                    userIn=Console.ReadLine();
                    if (userIn == "1")
                    {
                        Console.WriteLine("Oops, there's no monsters to fight please comeback another time.");
                    }
                    else if (userIn == "2")
                    {
                        doneFighting=true;
                    }
                    else if (userIn == "3")
                    {
                        doneFighting=true;
                        done=true;
                    }
                    else
                    {
                        Console.WriteLine("Oops, we didn't understand that. Please input a valid option.");
                    }
                }
            }
            else if (userIn == "2")
            {
                Console.WriteLine("It seems you don't have enought experience to level up. Please come back after killing more monsters");
            }
            else if (userIn == "3")
            {
                Console.WriteLine("You do not have an inventory at this time");
            }
            else if (userIn == "4")
            {
                done = true;
            }
        }
    }
}