public class Activity{
    //protected string _name;
    protected string _intro;

    public int activityIntroduction(string name){
        Console.Write($"Welcome to the {name} activity.\n\n{_intro}\n\nHow long, in seconds, would you like for your session?");
        int time = Int32.Parse(Console.ReadLine());
        return time;
    }
    public void loadingBar(int time){
        for(int i=0; i < time; i++){
            Console.Write("|");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}