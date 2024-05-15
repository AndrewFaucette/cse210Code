public class Entry{
    public string _entryDate;
    public string _entryText;
    public string _prompt;
    public void DisplayEntry() {
        Console.WriteLine($"Date: {_entryDate}\nPrompt: \"{_prompt}\"\n{_entryText}");
    }
}