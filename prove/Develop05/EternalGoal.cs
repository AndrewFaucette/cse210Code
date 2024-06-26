public class EternalGoal : Goal{
    private string _description = "This is a eternal goal that you set once and complete over and over again.";
    private int _completed = 0;

    public EternalGoal(string goal) :base(goal){
    
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
}