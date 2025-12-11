class Enemy :Character
{
    private int _regen;

    public Enemy(string name, int hp, int atk, int str, int agl, int intel, int def, int res, int xp):base(name, hp, atk, str, agl, intel, def, res, xp)
    {
        SetRegen(0);
    }
        public Enemy(string name, int hp, int atk, int str, int agl, int intel, int def, int res, int xp, int regen):base(name, hp, atk, str, agl, intel, def, res, xp)
    {
        SetRegen(regen);
    }

    public Enemy(string name, int hp, int atk, int str, int agl, int intel, int def, int res, int xp, int regen, List<Equipment> inventory):base(name, hp, atk, str, agl, intel, def, res, xp, inventory)
    {
        SetRegen(regen);
    }
    public Enemy(string name, int hp, int atk, int str, int agl, int intel, int def, int res, int xp, List<Equipment> inventory):base(name, hp, atk, str, agl, intel, def, res, xp, inventory)
    {
        SetRegen(0);
    }
    public void SetRegen(int regen)
    {
        _regen = regen;
    }
    public int GetRegen()
    {
        return _regen;
    }

    public override void DisplayStats()
    {
        Console.WriteLine();
    }
    public override void DisplayInventory()
    {
        if (_inventory == null)
        {
            Console.WriteLine($"{_name} does not have an inventory.");
        }
        else
        {
            foreach(Equipment item in _inventory)
            {
                continue;
            }
        }
    }
}