class MathAssignment : Assignment
{
    public string _textbookSection;
    public string _problems;
    public MathAssignment(string section, string problems, string name, string topic) : base(name, topic)
    {
        _textbookSection=section;
        _problems=problems;
    }
    public string GetHomeworkList()
    {
        return$"{GetSummary()}\nSection {_textbookSection} Problems {_problems}";
    }
}