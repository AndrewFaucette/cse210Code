using System;

class Program {
    static void Main(string[] args) {
        Scripture scripture = new Scripture();
        scripture.splitScripture(scripture.GetFullText());
        scripture.displayScripture();
        Console.WriteLine("\nPress enter to continue or type \"quit\" to quit");
        scripture.menu();
    }
}