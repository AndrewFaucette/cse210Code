using System;
using System.Globalization;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        /*journal1.writeNewEntry();
        journal1.displayJournal();*/
        String menuOption;
        do {
            menuOption = journal1.displayMenu();
            if(menuOption == "1"){
                journal1.writeNewEntry();
            } else if (menuOption == "2"){
                journal1.displayJournal();
            } else if (menuOption == "3"){
                journal1.saveToFile();
            } else if (menuOption == "4"){
                journal1.loadFromFile();
            } else if (menuOption == "5"){
                journal1.saveToFile();
                Console.WriteLine("bye");
            } else {
                Console.WriteLine("That was not a correct input");
            }
        } while (menuOption != "5");
    }
}