using System;
using System.Diagnostics;

class Program {
    static void Main(string[] args){
        List<Goal> goals = new List<Goal>();
        bool run = true;
        while(run){
            Console.WriteLine("What would you like to do?\n1. View Goals\n2. Set a New Goal\n3. Quit");
            int menu1 = Int32.Parse(Console.ReadLine());
            switch(menu1){
                case 1:
                    break;
                case 2:
                    Console.WriteLine("What kind of goal would you like to set?\n1. Simple\n2. Eternal\n3. Checklist\n4. Cancel");
                    int menu2 = Int32.Parse(Console.ReadLine());
                    Console.Write("What would you like to name your goal? ");
                    string name = Console.ReadLine();
                    switch(menu2){
                        case 1:
                            SimpleGoal simpleGoal = new SimpleGoal(name);
                            goals.Add(simpleGoal);
                            break;
                        case 2:
                            EternalGoal eternalGoal = new EternalGoal(name);
                            goals.Add(eternalGoal);
                            break;
                        case 3:
                            Console.Write("How many items are in your checklist?");
                            int num = Int32.Parse(Console.ReadLine());
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, num);
                            goals.Add(checklistGoal);
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("that is not a valid input");
                            break;
                    }
                    break;
                case 3:
                    run = false;
                    break;
                default:
                    Console.WriteLine("that is not a valid input");
                    break;
            }
        }
        foreach (Goal goal in goals){
            Console.WriteLine(goal.displayGoal());
        }
    }
}