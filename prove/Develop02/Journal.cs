using System;
using System.IO; 

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

        Random random = new Random();
        e._prompt = _prompts[random.Next(0,4)];
        Console.WriteLine(e._prompt);
        Console.Write("Entry: ");
        e._entryText = Console.ReadLine();
        _entries.Add(e);
    }

    public String displayMenu(){
        Console.WriteLine("Choose an option (enter a number 1-4)");
        Console.Write("1. Write a new entry 2. Display the Journal\n3. Save the journal to a file ");
        Console.WriteLine("4. Load the journal from a file\n5. quit the program (will load to file)");
        String choice = Console.ReadLine();
        return choice;        
    }

    public void saveToFile(){
        List<string> loadingJournal = new List<string>();
        foreach (Entry e in _entries){
            loadingJournal.Add($"{e._entryDate}@@{e._prompt}@@{e._entryText}");
        }
        System.IO.File.WriteAllLines(@"C:\Users\Owner\Documents\2024 Spring\cse210Code\prove\Develop02\journalFile.txt", loadingJournal);
    }

    public void loadFromFile(){
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Owner\Documents\2024 Spring\cse210Code\prove\Develop02\journalFile.txt");
        foreach (string line in lines){
            string[] parts = line.Split("@@");
            Entry e = new Entry();
            e._entryDate = parts[0];
            e._prompt = parts[1];
            e._entryText = parts[2];
            _entries.Add(e);
        }
    }
}