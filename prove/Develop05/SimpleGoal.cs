public class SimpleGoal : Goal{
    private string _complete;

    public SimpleGoal(string goal, string complete) :base(goal){
        _complete = complete;
    }

    public override int completeGoal(){
        Console.WriteLine("Congratulations you completed your simple goal! You get 1000 points!");
        _complete = "complete";
        return 1000;
    }

    public override string displayGoal(){
        return $"{_goal}: {_complete}";
    }
    public override string saveGoal(){
        return $"SG@@{_goal}@@{_complete}";
    }
}