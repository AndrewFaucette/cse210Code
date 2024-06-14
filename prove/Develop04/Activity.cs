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

    public bool activityOutro(){
        Console.WriteLine($"\nWell done!\nYou have completed another {time} seconds of the {_name} Activity.");
        Console.Write($"Would you like to do another {_name} Activity? (y/n) ");
        string answer = Console.ReadLine();
        while(true){
            if ((answer == "y") || (answer == "Y")){
                return true;
            } else if ((answer == "n") || (answer == "N")){
                return false;
            } else {
                Console.WriteLine("That is not a valid input");
                loadingBar(2);
            }
        }
    }
    public void loadingBar(int delay){
        for(int i=0; i < delay; i++){
            Console.Write("|");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}