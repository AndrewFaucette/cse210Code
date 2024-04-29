using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter your grade: ");
        string gradeInput = Console.ReadLine();
        int realGrade = int.Parse(gradeInput);
        if (realGrade >= 90) {
            Console.WriteLine("You got an A and you passed!");
        } else if (realGrade >= 80) {
            Console.WriteLine("You got an B and you passed!");
        } else if (realGrade >= 70) {
            Console.WriteLine("You got an C and you passed!");
        } else if (realGrade >= 60) {
            Console.WriteLine("You got an D and you failed");
        } else {
            Console.WriteLine("You got an F and you failed");
        } 
    }
}