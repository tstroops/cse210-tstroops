class Combat : Menu
{
    private Random rand = new Random();
    private int index;
    private Enemy[] _roster;
    public Combat(string[] options, Enemy[] roster):base(options)
    {
        _roster=roster;
    }
    
    public Enemy DisplayEnemy()
    {
        index=rand.Next(_roster.Length);
        return _roster[index];
    }
}