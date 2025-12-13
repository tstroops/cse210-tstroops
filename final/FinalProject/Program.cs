using System;
using System.Transactions;
using Microsoft.VisualBasic;

class Program
{
    public static void Reset(Enemy enemy, Player user)
    {
        user.SetHp(user.GetMax());
        enemy.SetHp(enemy.GetMax());
    }
    static void Main(string[] args)
    {
        Random rand = new Random();
        
        //non-magic items
        Armor ironArmor= new Armor("Iron Armor", 10, 5);
        Weapon ironSword = new Weapon("Iron Sword", 10, false);
        Armor steelArmor = new Armor("Steel Armor", 25, 10);
        Weapon steelSword = new Weapon("Steel Sword", 20, false);
        //you'd die too quickly without these
        Armor adamantineArmor = new Armor("Adamantine Armor", 75, 50);
        Weapon adamantineSword = new Weapon("Adamantine Sword", 90, false);
        
        //magic items
        Armor robe = new Armor("Robe", 5, 10);
        Weapon wand = new Weapon("Wand", 5, true);
        //or these
        Armor superRobe = new Armor("Golden Robes of Ultimate Power", 65, 100);
        Weapon superWand = new Weapon("Super Wand of Instant Vaporization", 65, true);


        Enemy dragon = new Enemy("Dragon", 1000, 100, 25, 25, 25, 100, 50, 5000);
        Enemy troll = new Enemy("Troll", 200, 20, 15, 15, 5, 5, 15, 500, 10, [steelArmor, steelSword]);
        Enemy currentEnemy;

        bool done=false;
        bool doneFighting;
        bool doneMng;
        bool dead;
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
        string[] levelOptions =
        {
            "You've leveled up!",
            "",
            "1. Strength",
            "2. Agility",
            "3. Intelligence",
            ""
        };

        Enemy[] enemies = [dragon, troll];

        Console.Write("Enter username: ");
        string username= Console.ReadLine();

        Player user = new Player(username, 100, 10, 10, 10, 10, 0, 0, [adamantineArmor, adamantineSword, superWand, superRobe]);
        Menu charMenu = new Menu(menuOptions);
        Combat combatMenu = new Combat(combatOptions, enemies);
        Menu inventoryMenu = new Menu(invOptions);
        Menu levelUp = new Menu(levelOptions);
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
                        currentEnemy = combatMenu.DisplayEnemy();
                        dead=false;
                        while(!dead)
                        {
                            currentEnemy.DisplayStats();
                            Console.Write("Do you attack (y/n)? ");
                            userIn=Console.ReadLine();
                            if (userIn.ToLower() == "n")
                            {
                                Console.WriteLine("Ok, you die. There is no room for pacifism here.");
                                user.SetHp(0);
                                doneFighting=true;
                                done=true;
                            }
                            else if (userIn.ToLower() == "y")
                            {
                                if (user.GetWeapon() != null)
                                {
                                    user.Attack(currentEnemy);
                                    Console.WriteLine($"You attack the monster with your {user.GetWeapon().GetName()}.");
                                }
                                else
                                {
                                    Console.WriteLine("You punch the monster.");
                                }
                                currentEnemy.Attack(user);
                                Console.WriteLine($"The {currentEnemy.GetName()} attacks you. Ouchies!");
                            }
                            else
                            {
                                Console.WriteLine("This is no time for nonsense! Input y or n.");
                            }
                            if (user.GetHp()<= 0)
                            {
                                dead=true;
                                Reset(currentEnemy, user);
                                Console.WriteLine("You died but got better.");
                            }
                            if (currentEnemy.GetHp() <= 0)
                            {
                                dead=true;
                                user.GainXp(currentEnemy.GetXp());
                                Reset(currentEnemy, user);
                                Console.WriteLine($"You killed the {currentEnemy.GetName()} and gained {currentEnemy.GetXp()} XP!");
                            }
                        }
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
                if (user.GetXp() >= 300)
                {
                    levelUp.Display();
                    Console.Write("Enter the attribute you wish to increase: ");
                    userIn=Console.ReadLine();
                    user.LevelUp(userIn);
                }
                else
                {
                    Console.WriteLine("It seems you don't have enough experience to level up. Please come back after killing more monsters");
                }
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