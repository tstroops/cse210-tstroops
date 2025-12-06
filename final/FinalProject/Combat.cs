class Combat : Menu
{
    private Enemy[] _roster;
    public Combat(string[] options, Enemy[] roster):base(options)
    {
        _roster=roster;
    }
    
}