using System.Threading.Channels;

abstract class Equipment
{
    protected string _name;
    protected bool _isEquipped;

    public Equipment(string name)
    {
        SetName(name);
        SetEquipStatus(false);
    }

    public Equipment(string name, bool equip)
    {
        SetEquipStatus(equip);
        SetName(name);
    }

    public abstract void DisplayStats();

    public bool GetEquipStatus()
    {
        return _isEquipped;
    }
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name=name;
    }

    public void SetEquipStatus(bool equip)
    {
        _isEquipped=equip;
    }
}