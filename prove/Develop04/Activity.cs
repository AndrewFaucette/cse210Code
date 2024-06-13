public class Activity{
    protected string _name;
    private int time;

    public Activity(string name){
        _name = name;
    }
    public int activityIntroduction(string intro){
        Console.WriteLine($"Welcome to the {_name} activity.\n\n{intro}");
        loadingBar(5);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        time = Int32.Parse(Console.ReadLine());
        return time;
    }

    public void activityOutro(){
        Console.WriteLine($"\n\nWell done!\nYou have completed another {time} seconds of the {_name} Activity.");
    }
    public void loadingBar(int delay){
        for(int i=0; i < delay; i++){
            Console.Write("|");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}