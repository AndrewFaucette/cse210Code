using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        journal1.writeNewEntry();
        journal1.displayJournal();
    }
}