class Enemy :Character
{
    private int _regen;

    public Enemy(int hp, int atk, int str, int agl, int intel, int def, int res, int xp, int regen, List<Equipment> inventory):base(hp, atk, str, agl, intel, def, res, xp, inventory)
    {
        SetRegen(regen);
    }
    public Enemy(int hp, int atk, int str, int agl, int intel, int def, int res, int xp, List<Equipment> inventory):base(hp, atk, str, agl, intel, def, res, xp, inventory)
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
}