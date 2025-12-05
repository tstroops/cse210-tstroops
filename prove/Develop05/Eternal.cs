class Eternal : Goal
{
    private int _timesComplete;

    public Eternal(string desc, string name, int points) : base(desc, name, points)
    {
        _timesComplete=0;
    }

    public Eternal(string desc, string name, int points, int times ):base(desc, name, points)
    {
        _timesComplete=times;
    }
    public override void Display()
    {
        Console.WriteLine($"[ ] {_name} ({_desc}) -- Completed {_timesComplete} time(s)");
    }

    public override string MakeString()
    {
        return $"eternal,{_name},{_desc},{_points},{_timesComplete}";
    }

    public override int Mark()
    {
        _timesComplete++;
        return _points;
    }
}