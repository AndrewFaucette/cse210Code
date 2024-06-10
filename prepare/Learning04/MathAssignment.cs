public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic) {
        _textbookSection = section;
        _problems = problems;
    }

    public string getHomework(){
        Console.WriteLine(GetSummary());
        return $"{_textbookSection}, {_problems}";
    }
}