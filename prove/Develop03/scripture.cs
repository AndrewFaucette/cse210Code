public class Scripture{
    private string _fullText = "James 4:7-8 7 Submit yourselves therefore to God. Resist the devil, and he will flee from you. 8 Draw nigh to God, and he will draw nigh to you. Cleanse your hands, ye sinners; and purify your hearts, ye double minded.";
    private List<Word> _words = new List<Word>();
    private List<int> _remainingWords = new List<int>();
    private Reference reference = new Reference();
    
    public void splitScripture(string fullScript){
        List<string> words = new List<string>(fullScript.Split(' '));
        reference.SetReference(words[0]+" "+words[1]);
        words.RemoveAt(0);
        words.RemoveAt(0);
        for(int i = 0; i < words.Count; i++){
            Word word = new Word();
            word.SetText(words[i]);
            if (int.TryParse(words[i], out _) == true){
                word.SetIsNumber(true);
            } else {
                _remainingWords.Add(i);
            }
            _words.Add(word);
        }
    }
    public void removeRandomWord(){
        Random random = new Random();
        int index = random.Next(0,_remainingWords.Count);
        int hider = _remainingWords[index];
        _words[hider].hide();
        _remainingWords.RemoveAt(index);
    }
    public void menu(){
        string input = "";
        do{
            input = Console.ReadLine();
            if (_remainingWords.Count >2){
                for(int i=0; i < 3; i++){removeRandomWord();}
            } else {
                for(int i=0; i < _remainingWords.Count; i++){removeRandomWord();}
            }
            displayScripture();
            Console.WriteLine("\nPress enter to continue or type \"quit\" to quit");
        }while (input != "quit");
    }
    public void displayScripture(){
        Console.Clear();
        reference.displayReference();
        foreach(Word word in _words){
            Console.Write(" ");
            word.displayWord();
        }
    }

    public List<Word> GetWords(){ return _words; }
    public void SetWords(List<Word> words){ _words = words; }

    public List<int> GetRemainingWords(){ return _remainingWords; }
    public void SetRemainingWords(List<int> remainingWords){ _remainingWords = remainingWords; }

    public string GetFullText(){ return _fullText; }
    public void SetFullText(string fullText){ _fullText = fullText; }
}