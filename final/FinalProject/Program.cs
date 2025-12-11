using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Armor ironArmor= new Armor("Iron Armor", 10, 5);
        Armor robe = new Armor("Robe", 5, 10);
        Weapon wand = new Weapon("Wand", 5, true);
        Weapon ironSword = new Weapon("Iron Sword", 10, false);


        Enemy dragon = new Enemy("Dragon", 1000, 100, 25, 25, 25, 100, 50, 5000);

        bool done=false;
        bool doneFighting;
        bool doneMng;
        string userIn;
        int index;
        
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
        string[] invOptions = [
            "1. Equip Item",
            "2. Discard Item",
            "3. Quit Inventory Manager",
            ""
        ];

        Enemy[] enemies = [dragon];

        Console.Write("Enter username: ");
        string username= Console.ReadLine();

        Player user = new Player(username, 100, 10, 0, 0, 0, 0, 0, [ironSword, ironArmor, wand, robe]);
        Menu charMenu = new Menu(menuOptions);
        Combat combatMenu = new Combat(combatOptions, enemies);
        Menu inventoryMenu = new Menu(invOptions);
        while (!done)
        {
            doneFighting=false;
            doneMng=false;
            user.DisplayStats();
            charMenu.Display();
            Console.Write("Select an option from the menu: ");
            userIn=Console.ReadLine();
            if (userIn == "1")
            {
                Console.Clear();
                while(!doneFighting)
                {
                    user.DisplayStats();
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
                        Console.Clear();
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
                Console.WriteLine("It seems you don't have enough experience to level up. Please come back after killing more monsters");
            }
            else if (userIn == "3")
            {
                Console.Clear();
                while (!doneMng)
                {
                    user.DisplayInventory();
                    Console.WriteLine();
                    inventoryMenu.Display();
                    Console.Write("Select an option from the menu: ");
                    userIn=Console.ReadLine();
                    if (userIn == "1")
                    {
                        Console.Clear();
                        user.DisplayInventory();
                        Console.Write("Input the item number you wish to equip: ");
                        index=int.Parse(Console.ReadLine()) - 1;
                        user.Equip(index);
                    }
                    else if (userIn == "2")
                    {
                        Console.Clear();
                        user.DisplayInventory();
                        Console.Write("Enter the number of the item you wish to discard: ");
                        index=int.Parse(Console.ReadLine()) - 1;
                        if (user.GetInventory()[index] == user.GetArmor())
                        {
                            user.SetDef(user.GetDef() - user.GetArmor().GetDef());
                            user.SetRes(user.GetRes() - user.GetArmor().GetRes());
                            user.UnequipArmor();
                        }
                        else if (user.GetInventory()[index] == user.GetWeapon())
                        {
                            user.SetAtk(user.GetAtk() - user.GetWeapon().GetDamage());
                            user.UnequipWeapon();
                        }
                        user.GetInventory().RemoveAt(index);
                    }
                    else if (userIn == "3")
                    {
                        doneMng=true;
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("We didn't understand that. Please input a valid number: ");
                    }
                }
                
            }
            else if (userIn == "4")
            {
                done = true;
            }
            else
            {
                Console.WriteLine("Oops, we did't understand that. Please input a valid option.");
            }
        }
    }
}