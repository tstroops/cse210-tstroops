using System.IO;

class Journal
{

    Random rand = new Random();
    public string _userName = "";
    string _prevUser = "";
    public string _date = "";

    public List<string> _dateHist = new List<string>();

    public string[] _promptBank =
    {
        "What wasted the most of my time today? ",
        "What went well today? ",
        "What made today different? ",
        "Why didn't the day go according to plan? ",
        "What would the current you say to the you from this morning? "
    };
    List<string> _promptHist = new List<string>();
    List<string> _responseHist = new List<string>();
    public void GetResponse()
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _dateHist.Add(_date);
        string prompt = _promptBank[rand.Next(5)];
        _promptHist.Add(prompt);
        Console.Write(prompt);
        _responseHist.Add(Console.ReadLine());

    }
    public void Display()
    {
        Console.WriteLine(_userName);
        for (int i = 0; i < _promptHist.Count; i++)
        {
            Console.WriteLine($"Date: {_dateHist[i]} - Prompt: {_promptHist[i]}");
            Console.WriteLine(_responseHist[i]);
        }
    }
    public void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_userName);
            for (int i = 0; i < _promptHist.Count; i++)
            {
                outputFile.WriteLine(_dateHist[i]);
                outputFile.WriteLine(_promptHist[i]);
                outputFile.WriteLine(_responseHist[i]);
            }
        }
    }
    public void Load(string fileName)
    {

        string[] lines = System.IO.File.ReadAllLines(fileName);

        _prevUser = _userName;
        _userName = lines[0];

        for (int i = 1; i < lines.Length; i += 3)
        {
            _dateHist.Add(lines[i]);
        }
        for (int i = 2; i < lines.Length; i += 3)
        {
            _promptHist.Add(lines[i]);
        }
        for (int i = 3; i < lines.Length; i += 3)
        {
            _responseHist.Add(lines[i]);
        }
        Display();
        _userName = _prevUser;
    }
}