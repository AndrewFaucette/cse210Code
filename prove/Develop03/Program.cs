using System;

class Program {
    static void Main(string[] args) {
        Scripture scripture = new Scripture();
        scripture.splitScripture(scripture.GetFullText());
        scripture.displayScripture();
    }
}