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
                //save journal
            } else if (menuOption == "4"){
                //load journal
            } else if (menuOption == "5"){
                //load journal and exit
            } else {
                Console.WriteLine("That was not a correct input");
            }
        } while (menuOption != "5");
    }
}