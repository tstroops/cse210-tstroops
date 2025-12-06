using System.Security.AccessControl;

class Armor : Equipment
{
    int _defense;
    int _resistance;

    public Armor(string name, int def, int res): base(name)
    {
        SetDef(def);
        SetRes(res);
    }

    public void SetDef(int def)
    {
        _defense=def;
    }
    public void SetRes(int res)
    {
        _resistance=res;
    }
    public override void Equip()
    {
        _isEquipped=true;
    }

    public int GetDef()
    {
        return _defense;
    }
    public int GetRes()
    {
        return _resistance;
    }
}