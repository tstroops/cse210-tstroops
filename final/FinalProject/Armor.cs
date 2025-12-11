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

    public Armor(string name, bool equip, int def, int res):base(name, equip)
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

    public override void DisplayStats()
    {
        Console.WriteLine($"{_name} -- Defense: {_defense} | Resistance: {_resistance}");
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