public class ChecklistGoal : Goal{
    private int _number;
    private int _completed;
    public ChecklistGoal(string goal, int number, int completed) :base(goal){
        _number = number;
        _completed = completed;
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
    public override string saveGoal(){
        return $"CG@@{_goal}@@{_completed}@@{_number}";
    }
}