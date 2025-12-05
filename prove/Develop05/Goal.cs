abstract class Goal
{
    protected string _name;
    protected string _desc;
    protected int _points;
    protected bool _complete;
    
    public Goal(string desc, string name, int points)
    {
        _name=name;
        _desc = desc;
        _points=points;
        _complete = false;
    }
    public Goal(string desc, string name, int points, bool isComplete)
    {
        _name=name;
        _complete=isComplete;
        _desc=desc;
        _points=points;
    }

    public abstract void Display();
    public abstract string MakeString();
    public abstract int Mark();
    public int getPoints()
    {
        return _points;
    }
}