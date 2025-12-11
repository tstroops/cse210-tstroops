class Weapon : Equipment
{
    private int _damage;
    private bool _isMagic;

    public Weapon(string name, int damage, bool isMagic) : base(name)
    {
        SetDamage(damage);
        SetIsMagic(isMagic);
    }

    public Weapon(string name, bool equip, int damage, bool isMagic):base(name, equip)
    {
        SetDamage(damage);
        SetIsMagic(isMagic);
    }

    public override void DisplayStats()
    {
        Console.WriteLine($"{_name} -- Damage: {_damage} | Magic: {_isMagic}");
    }

    public int GetDamage()
    {
        return _damage;
    }
    public bool IsItMagic()
    {
        return _isMagic;
    }

    public void SetDamage(int damage)
    {
        _damage=damage;
    }
    public void SetIsMagic(bool isMagic)
    {
        _isMagic=isMagic;
    }
}