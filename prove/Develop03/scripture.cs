public class Scripture{
    private string _fullText = "James 4:7-8 7 Submit yourselves therefore to God. Resist the devil, and he will flee from you. 8 Draw nigh to God, and he will draw nigh to you. Cleanse your hands, ye sinners; and purify your hearts, ye double minded.";
    private List<Word> _words = new List<Word>();
    private List<int> _remainingWords = new List<int>();

    private Reference reference = new Reference();
    
    public void splitScripture(string fullScript){
        string[] words = fullScript.Split(' ');
        reference.SetReference(words[0]+" "+words[1]);
        for(int i = 2; i < words.Length; i++){
            Word word = new Word();
            _words.Add(word);
            if (int.TryParse(words[i], out _) == true){
                word.SetIsNumber(true);
            } else {
                _remainingWords.Add(i-2);
            }
        }
    }
    public void removeRandomWord(){
        Random random = new Random();
        int index = _remainingWords[random.Next(0,_remainingWords.Count)];
        _words[index].hide();
        _remainingWords.RemoveAt(index);
    }
    public void displayScripture(){
        reference.displayReference();
        for(int i = 0; i<_words.Count; i++){
            _words[i].displayWord();
        }
    }

    public List<Word> GetWords(){ return _words; }
    public void SetWords(List<Word> words){ _words = words; }

    public List<int> GetRemainingWords(){ return _remainingWords; }
    public void SetRemainingWords(List<int> remainingWords){ _remainingWords = remainingWords; }

    public string GetFullText(){ return _fullText; }
    public void SetFullText(string fullText){ _fullText = fullText; }
}