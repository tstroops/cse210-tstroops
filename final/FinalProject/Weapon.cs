class Weapon : Equipment
{
    private int _damage;
    private bool _isMagic;

    public Weapon(string name, int damage, bool isMagic) : base(name)
    {
        _damage=damage;
        _isMagic=isMagic;
    }

    public override void Equip()
    {
        _isEquipped=true;
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