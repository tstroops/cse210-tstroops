class Checklist:Goal
{
    private int _timesComplete;
    private int _requirement;
    private int _bonus;

    public Checklist(string desc, string name, int points, int requirement, int bonus):base(desc, name, points)
    {
        _timesComplete=0;
        _requirement=requirement;
        _bonus=bonus;
    }
    public Checklist(string desc, string name, int points, int requirement, int bonus, bool isComplete, int times):base(desc, name, points, isComplete)
    {
        _timesComplete=times;
        _requirement=requirement;
        _bonus=bonus;
    }
    public override void Display()
    {
        if (_complete)
        {
            Console.WriteLine($"[X] {_name} ({_desc}) -- Completed {_timesComplete}/{_requirement}");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_desc}) -- Completed {_timesComplete}/{_requirement}");
        }
    }
    public override string MakeString()
    {
        return $"checklist,{_name},{_desc},{_points},{_complete},{_timesComplete},{_requirement},{_bonus},{_timesComplete}";
    }
    public override int Mark()
    {
        _timesComplete++;
        if (_timesComplete != _requirement)
        {
            return _points;
        }
        else
        {
            _complete=true;
            return _points+_bonus;
        }
    }
}