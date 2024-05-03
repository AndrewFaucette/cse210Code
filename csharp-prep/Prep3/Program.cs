using System;

class Program {
    static void Main(string[] args){
        string play = "y";
        while (play == "y"){
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            string guess = "";
            int gu3ss = 0;
            int guesses = 0;
            do {
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                gu3ss = int.Parse(guess);
                if (gu3ss > magicNumber){
                    Console.WriteLine("Lower");
                } else if (gu3ss < magicNumber){
                    Console.WriteLine("Higher");
                } else {
                    Console.WriteLine("Correct!");
                }
                guesses++;
            } while (gu3ss != magicNumber);
            Console.WriteLine($"It took you {guesses} guesses");
            Console.Write("Do you want to keep playing?(y/n) ");
            play = Console.ReadLine();
        }
    }
}