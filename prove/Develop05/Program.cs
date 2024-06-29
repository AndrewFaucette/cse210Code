using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Program {
    static void Main(string[] args){
        List<Goal> goals = new List<Goal>();
        int points = 0;
        loadFromFile();
        bool run = true;
        while(run){
            Console.WriteLine("What would you like to do?\n1. View Goals\n2. Set a New Goal\n3. Complete a Goal\n4. Quit");
            int menu1 = Int32.Parse(Console.ReadLine());
            switch(menu1){
                case 1:
                    Console.WriteLine($"points: {points}");
                    displayGoals();
                    break;
                case 2:
                    Console.WriteLine("What kind of goal would you like to set?\n1. Simple\n2. Eternal\n3. Checklist\n4. Cancel");
                    int menu2 = Int32.Parse(Console.ReadLine());
                    Console.Write("What would you like to name your goal? ");
                    string name = Console.ReadLine();
                    switch(menu2){
                        case 1:
                            SimpleGoal simpleGoal = new SimpleGoal(name, "incomplete");
                            goals.Add(simpleGoal);
                            break;
                        case 2:
                            EternalGoal eternalGoal = new EternalGoal(name, 0);
                            goals.Add(eternalGoal);
                            break;
                        case 3:
                            Console.Write("How many items are in your checklist? ");
                            int num = Int32.Parse(Console.ReadLine());
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, num, 0);
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
                    displayGoals();
                    Console.Write("Which goal would you like to complete? ");
                    try {
                    int index = Int32.Parse(Console.ReadLine())-1;
                    points += goals[index].completeGoal();
                    } catch (Exception e) {
                        Console.WriteLine("That isn't a valid input");
                    }
                    if (points%1000 == 0){
                        for(int i = 0; i<3; i++){
                            Console.Write("_-.-_");
                            Thread.Sleep(500);
                            Console.Write("\b\b\b\b\b\\-o-/");
                            Thread.Sleep(500);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    run = false;
                    break;
                default:
                    Console.WriteLine("that is not a valid input");
                    break;
            }
            saveToFile();
        }
        void displayGoals(){
            int i = 0;
            foreach (Goal goal in goals){
                i++;
                Console.Write($"{i}. ");
                Console.WriteLine(goal.displayGoal());
            }
        }
        void saveToFile(){
            List<string> loadingJournal = new List<string>();
            loadingJournal.Add(points.ToString());
            foreach (Goal g in goals){
                loadingJournal.Add(g.saveGoal());
            }
            System.IO.File.WriteAllLines(@"C:\Users\Owner\Documents\2024 Spring\cse210Code\prove\Develop05\goalFile.txt", loadingJournal);
        }
        void loadFromFile(){
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Owner\Documents\2024 Spring\cse210Code\prove\Develop05\goalFile.txt");
            points = Int32.Parse(lines[0]);
            foreach (string line in lines){
                string[] parts = line.Split("@@");
                if (parts.Length != 1){
                    switch(parts[0]){
                        case "SG":
                            SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2]);
                            goals.Add(simpleGoal);
                            break;
                        case "EG":
                            EternalGoal eternalGoal = new EternalGoal(parts[1], Int32.Parse(parts[2]));
                            goals.Add(eternalGoal);
                            break;
                        case "CG":
                            ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], Int32.Parse(parts[2]), Int32.Parse(parts[3]));
                            goals.Add(checklistGoal);
                            break;
                    }
                }
            }
        }
    }
}