using System;
using System.Globalization;

public class Journal {
    public List<string> _prompts = new List<string>();
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
        Console.WriteLine("Entry:");
        e._entryText = Console.ReadLine();
        _entries.Add(e);
    }
}