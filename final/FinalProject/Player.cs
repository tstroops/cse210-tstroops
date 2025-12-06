class Player: Character
{
    private int _level;

    public Player(int hp, int atk, int str, int agl, int intel, int def, int res, List<Equipment> inventory):base(hp, atk, str, agl, intel, def, res, inventory)
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
}