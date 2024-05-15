using System;

public class Journal {
    public List<string> _prompts = new List<string>{"What was your favorite part of today?", "What was the worst part of your day?", "Have you done any good in the world today?", "What did you learn today?", "How much wood would a wood chuck chuck if a wood chuck could chuck wood?"};
    public string _journalName;
    public List<Entry> _entries = new List<Entry>();
    
    public void displayJournal(){
        foreach(Entry e in _entries){
            e.DisplayEntry();
        }
    }
    public void writeNewEntry(){
        Entry e = new Entry();
        DateTime localDate = DateTime.Now;
        e._entryDate = localDate.ToString();

        //e._prompt = 
        Console.Write("Entry: ");
        e._entryText = Console.ReadLine();
        _entries.Add(e);
    }
    public String displayMenu(){
        Console.WriteLine("Choose an option (enter a number 1-4)");
        Console.WriteLine("1. Write a new entry\n2. Display the Journal\n3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file\n5. quit the program(will load to file)");
        String choice = Console.ReadLine();
        return choice;        
    }
}