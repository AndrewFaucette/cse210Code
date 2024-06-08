public class WritingAssignment : Assignment{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic){
        _title = title;
    }

    public string getWritingInformation(){
        Console.WriteLine(GetSummary());
        return $"{_title} by {_studentName}";
    }
}