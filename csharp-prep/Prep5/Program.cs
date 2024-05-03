using System;

class Program {
    static void Main(string[] args){
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int square = squareNumber(num);
        DisplayResult(square, name);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.Write("Please enter your number: ");
        string number = Console.ReadLine();
        int num = int.Parse(number);
        return num;
    }
    static int squareNumber(int num){
        return num * num;
    }
    static void DisplayResult(int square, string name){
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}