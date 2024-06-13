public class ReflectionActivity : Activity{
    string _intro = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    List<string> prompts = new List<string>{"made a good decision.", "helped someone else.", "felt the spirit.", "had a really good day."};
    List<string> questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    public ReflectionActivity(string name) :base(name){

    }

    public void performActivity(){
        int time = activityIntroduction(_intro);
        Random random = new Random();
        while(time > 0){
            int prompt = random.Next(0,prompts.Count());
            Console.WriteLine($"\nThink of a time when you {prompts[prompt]}");
            loadingBar(6);
            time -= 6;
            if (time < 1){ break; }
            int question = random.Next(0,questions.Count());
            Console.WriteLine($"{questions[question]}");
            loadingBar(10);
            time -= 10;
        }
    }
}