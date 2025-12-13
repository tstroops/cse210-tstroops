using System.Security.Cryptography;

abstract class Character
{
    protected string _name;
    protected int _hp;
    protected int _maxHp;
    protected int _atk;
    protected int _str;
    protected int _agl;
    protected int _int;
    protected int _def;
    protected int _res;
    protected int _xp;
    protected List<Equipment> _inventory;
    protected Armor _equippedArmor;
    protected Weapon _equippedWeapon;


    private void InitializeStats(string name, int hp, int atk, int str, int agl, int intel, int def, int res)
    {
        SetName(name);
        _maxHp=hp;
        SetHp(hp);
        SetAtk(atk);
        SetStr(str);
        SetAgl(agl);
        SetInt(intel);
        SetDef(def);
        SetRes(res);
    }
    public Character(string name, int hp, int atk, int str, int agl, int intel, int def, int res, int xp)
    {
        InitializeStats(name, hp, atk, str, agl, intel, def, res);
        SetXp(xp);
        SetInventory(null);
    }
    public Character(string name, int hp, int atk, int str, int agl, int intel, int def, int res, int xp, List<Equipment> inventory)
    {
        InitializeStats(name, hp, atk, str, agl, intel, def, res);
        SetXp(xp);
        SetInventory(inventory);
    }

    public Character(string name, int hp, int atk, int str, int agl, int intel, int def, int res, List<Equipment> inventory)
    {
        InitializeStats(name, hp, atk, str, agl, intel, def, res);
        SetXp(0);
        SetInventory(inventory);
    }

    
    public void SetName(string name)
    {
        _name=name;
    }
    public void SetHp(int hp)
    {
        _hp=hp;
    }
    public void GainHp(int gain)
    {
        _hp+=gain;
    }
    public void LoseHp(int loss)
    {
        _hp-=loss;
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
    
    public string GetName()
    {
        return _name;
    }
    public int GetHp()
    {
        return _hp;
    }
    public int GetMax()
    {
        return _maxHp;
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

    public Armor GetArmor()
    {
        return _equippedArmor;
    }
    public Weapon GetWeapon()
    {
        return _equippedWeapon;
    }

    public void UnequipArmor()
    {
        _equippedArmor=null;
    }
    public void UnequipWeapon()
    {
        _equippedWeapon=null;
    }

    public abstract void DisplayStats();
    public abstract void DisplayInventory();
    public void Attack(Character target)
    {
        int damage;
        if (_equippedWeapon!=null && _equippedWeapon.IsItMagic())
        {
            damage=_atk + _int - target.GetAgl() - target.GetRes();
        }
        else
        {
            damage=_atk + _str - target.GetAgl() - target.GetDef();
        }
        if (damage < 0)
        {
            return;
        }
        target.LoseHp(damage);
        if(target is Enemy enemy)
        {
            enemy.GainHp(enemy.GetRegen());
        }
    }

    public void Equip(int index)
    {
        if (index >=0 && index < _inventory.Count)
        {
            if(_inventory[index] is Armor newArmor && _equippedArmor!=null)
            {
                SetDef(GetDef() - _equippedArmor.GetDef() + newArmor.GetDef());
                SetRes(GetRes() - _equippedArmor.GetRes() + newArmor.GetRes());
                _equippedArmor = newArmor;
            }
            else if (_inventory[index] is Armor armor2)
            {
                SetDef(GetDef() + armor2.GetDef());
                SetRes(GetRes() + armor2.GetRes());
                _equippedArmor = armor2;
            }
            else if(_inventory[index] is Weapon newWeapon && _equippedWeapon!=null)
            {
                SetAtk(GetAtk() - _equippedWeapon.GetDamage() + newWeapon.GetDamage());
                _equippedWeapon=newWeapon;
            }
            else if (_inventory[index] is Weapon weapon2)
            {
                SetAtk(GetAtk() + weapon2.GetDamage());
                _equippedWeapon = weapon2;
            }
        }
    }
}