public abstract class Player{
    protected List<int> _hand = new List<int>();
    public Foot foot = new Foot();
    protected int _points = 0;

    public void displayHand(){
        foreach (int card in _hand){
            Console.Write($"{card} ");
        }
        Console.WriteLine();
    }
    public void setHand(List<int> hand, bool setFoot = false){
        _hand = hand;
        if (setFoot) { foot.setFoot(_hand); }
            hand.Sort();
    }
    public List<int> getHand(){ return _hand; }
    public abstract List<int> play();
}