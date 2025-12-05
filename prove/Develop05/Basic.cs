class Basic : Goal
{
    public Basic(string desc,string name, int points):base(desc, name, points){}

        public Basic(string desc, string name, int points, bool isComplete):base(desc,name, points, isComplete){}
    public override string MakeString()
    {
        return $"basic,{_name},{_desc},{_points},{_complete}";
    }
    public override void Display()
    {
        if (_complete)
        {
            Console.WriteLine($"[X] {_name} ({_desc})");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_desc})");
        }
    }
    public override int Mark()
    {
        _complete = true;
        return _points;
    }
}