public class ListingActivity : Activity{
    string _intro = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    List<string> prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    public ListingActivity(string name) :base(name){
    }

    public void performActivity(){
        int time = activityIntroduction(_intro);
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(0, prompts.Count())]);
        Console.WriteLine("\nThink about items to list");
        loadingBar(8);
        Console.WriteLine("Now list as many items as you can");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time-8);
        int count = 0;
        while(true){
            string entry = Console.ReadLine();
            if (entry.Length > 0){count++;}
            startTime = DateTime.Now;
            if(startTime > futureTime){break;}
        }
        Console.WriteLine($"You listed {count} things.");
        activityOutro();
    }
}