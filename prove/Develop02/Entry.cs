class Entry
{
    public string _response = "";
    public string _prompt = "";
    public string _date = "";
    public string[] _promptBank =
    {
        "What wasted the most of my time today? ",
        "What went well today? ",
        "What made today different? ",
        "Why didn't the day go according to plan? ",
        "What would the current you say to the you from this morning? "
    };
    Random rand = new Random();
    public void GetResponse()
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _prompt = _promptBank[rand.Next(5)];
        Console.Write(_prompt);
        _response = Console.ReadLine();
    }
}