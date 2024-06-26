public abstract class Goal{

    
    protected string _goal;
    public Goal (string goal){
        _goal = goal;
    }

    //public abstract void setGoal();
    public abstract int completeGoal();
    public abstract string displayGoal();
}