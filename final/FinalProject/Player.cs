class Player: Character
{
    private int _level;

    public Player(string name, int hp, int atk, int str, int agl, int intel, int def, int res, List<Equipment> inventory):base(name, hp, atk, str, agl, intel, def, res, inventory)
    {
        SetLevel(0);
    }
    public void SetLevel(int lvl)
    {
        _level=lvl;
    }
    public int GetLevel()
    {
        return _level;
    }
    
    public override void DisplayInventory()
    {
        if (_inventory.Count == 0)
        {
            Console.WriteLine("You do not have any items in your inventory");
        }
        else
        {
            for (int i=0; i<_inventory.Count; i++)
            {
                Console.Write($"{i+1}. ");
                _inventory[i].DisplayStats();
            }
        }
    }
    public override void DisplayStats()
    {
        Console.WriteLine($"{_name} -- Level: {_level} | XP: {_xp}");
        Console.WriteLine($"Attributes -- Strength: {_str} | Agility: {_agl} | Intelligence: {_int}");
        Console.WriteLine($"Combat Stats -- HP: {_hp} | Atk: {_atk} | Def: {_def} | Res: {_res}");
    }
}