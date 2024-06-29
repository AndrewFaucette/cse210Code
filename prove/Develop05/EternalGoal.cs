public class EternalGoal : Goal{
    private int _completed;

    public EternalGoal(string goal, int completed) :base(goal){
        _completed = completed;
    }

    public override int completeGoal(){
        _completed++;
        double x = 10 + Math.Pow(2, _completed);
        int points = Convert.ToInt32(x);
        Console.WriteLine($"Congratulations you completed an eternal goal! You get {points} points!");
        return points;
    }
    public override string displayGoal(){
        return $"{_goal}: completed {_completed} times";
    }
    public override string saveGoal(){
        return $"EG@@{_goal}@@{_completed}";
    }
}