class Character
{
    protected int _hp;
    protected int _atk;
    protected int _str;
    protected int _agl;
    protected int _int;
    protected int _def;
    protected int _res;
    protected int _xp;
    protected List<Equipment> _inventory;

    public Character(int hp, int atk, int str, int agl, int intel, int def, int res, int xp, List<Equipment> inventory)
    {
        SetHp(hp);
        SetAtk(atk);
        SetStr(str);
        SetAgl(agl);
        SetInt(intel);
        SetDef(def);
        SetRes(res);
        SetXp(xp);
        SetInventory(inventory);
    }

public Character(int hp, int atk, int str, int agl, int intel, int def, int res, List<Equipment> inventory)
    {
        SetHp(hp);
        SetAtk(atk);
        SetStr(str);
        SetAgl(agl);
        SetInt(intel);
        SetDef(def);
        SetRes(res);
        SetXp(0);
        SetInventory(inventory);
    }

    public void SetHp(int hp)
    {
        _hp=hp;
    }
    public void SetAtk(int atk)
    {
        _atk=atk;
    }
    public void SetStr(int str)
    {
        _str=str;
    }
    public void SetAgl(int agl)
    {
        _agl=agl;
    }
    public void SetInt(int intel)
    {
        _int=intel;
    }
    public void SetDef(int def)
    {
        _def=def;
    }
    public void SetRes(int res)
    {
        _res=res;
    }
    public void SetXp(int xp)
    {
        _xp=xp;
    }

    public void SetInventory(List<Equipment> inventory)
    {
        _inventory=inventory;
    }
    public int GetHp()
    {
        return _hp;
    }
    public int GetAtk()
    {
        return _atk;
    }
    public int GetStr()
    {
        return _str;
    }
    public int GetAgl()
    {
        return _agl;
    }
    public int GetInt()
    {
        return _int;
    }
    public int GetDef()
    {
        return _def;
    }
    public int GetRes()
    {
        return _res;
    }
    public int GetXp()
    {
        return _xp;
    }

    public List<Equipment> GetInventory()
    {
        return _inventory;
    }

    public void DisplayStats()
    {
        
    }
    public void DisplayInventory()
    {
        
    }
    public void Attack()
    {
        
    }
}