public class BreathingActivity : Activity{
    //string _name = "Breathing";
    string _intro = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public BreathingActivity (string name) :base (name){

    }

    public void performActivity(){
        int time = activityIntroduction(_intro);
        for(int i = time; i>0;){
            Console.Write("\n\nBreath in ");
            for(int j = 5; j>0; j--){
                if(i==0){ break; }
                Console.Write($"{j}\b");
                Thread.Sleep(1000);
                i--;
            }
            Console.Write(" \nBreath out ");
            for(int k = 5; k>0; k--){
                if(i==0){ break; }
                Console.Write($"{k}\b");
                Thread.Sleep(1000);
                i--;
            }
            Console.Write(" ");
        }
        activityOutro();
    }
}