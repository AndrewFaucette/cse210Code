public class Scripture{
    private string _fullText;
    private List<Word> _words = new List<Word>();
    private List<int> _remainingWords = new List<int>();
    

    public void removeRandomWord(){
        Random random = new Random();
        int index = _remainingWords[random.Next(0,_remainingWords.Count)];
        _words[index].hide();
    }
}