public class ChecklistGoal : Goal{
    private string _description = "This is a Checklist goal where you seta goal to accomplish a certain number of times.";
    private int _number;
    private int _completed = 0;
    public ChecklistGoal(string goal, int number) :base(goal){
        _number = number;
    }

    public override int completeGoal(){
        _completed++;
        int points;
        if(_completed >= _number){
            points = 1000 + (_completed * 100);
            Console.WriteLine($"Congratulations you completed your Checklist goal! You get {points} points!");
            return points;
        } else {
            points = 100 + (_completed*10);
            Console.WriteLine($"You cave completed {_completed} out of {_number} and you get {points} points.");
            return points;
        }
    }
    public override string displayGoal(){
        return $"{_goal}: completed {_completed}/{_number} times";
    }
}