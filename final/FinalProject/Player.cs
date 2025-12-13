using System.Data;

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

    public void GainXp(int gain)
    {
        _xp+=gain;
    }
    public void LevelUp(string stat)
    {
        stat=stat.ToLower();
        if (_xp >= 300)
        {
            _level+=1;
            _maxHp+=10;
            _hp=_maxHp;
            _xp-=300;
            if (stat == "strength" || stat=="1")
            {
                _str++;
            }
            else if (stat == "agility" || stat=="2")
            {
                _agl++;
            }
            else if (stat == "intelligence" || stat=="3")
            {
                _int++;
            }
        }

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