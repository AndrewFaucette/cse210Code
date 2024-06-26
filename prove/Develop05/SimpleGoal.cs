public class SimpleGoal : Goal{
    private string _description = "This is a simple goal that you set once and complete once.";
    private string _complete = "incomplete";

    public SimpleGoal(string goal) :base(goal){
    
    }

    public override int completeGoal(){
        Console.WriteLine("Congratulations you completed your simple goal! You get 1000 points!");
        _complete = "complete";
        return 1000;
    }

    public override string displayGoal(){
        return $"{_goal}: {_complete}";
    }
}