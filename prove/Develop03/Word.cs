using System.Threading.Tasks.Dataflow;

class Word
{
    private string _word;
    private bool _hidden;
    
    public Word(string word)
    {
        _word = word;
        _hidden = false; 
    }
    
    public string Write()
    {
        if (!_hidden)
        {
            return _word;
        }
        else
        {
            string _hiddenWord = "";
            foreach (char c in _word)
            {
                _hiddenWord+="_";
            }
            return _hiddenWord;
        }
    }
    
    public void Hide()
    {
        _hidden = true;
    }
    
    public bool checkHidden()
    {
        return _hidden;
    }
}