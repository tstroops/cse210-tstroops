using System.Threading.Channels;

abstract class Equipment
{
    protected string _name;
    protected bool _isEquipped;

    public Equipment(string name)
    {
        _name=name;
        _isEquipped=false;
    }

    public abstract void Equip();

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

    public void setEquipStatus(bool equip)
    {
        _isEquipped=equip;
    }
}