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

    //method to change the hand to the input list, you can also rest the foot
    public void setHand(List<int> hand, bool setFoot = false){
        _hand = hand;
        if (setFoot) { foot.setFoot(_hand); }
        hand.Sort();
    }
    public int addPoints(){
        //add the remaining cards a player has into their score, 1-9 add their
        //value, 10s are 20 points, and 11-13 are worth 10 points
        foreach (int card in foot.faceUp) { _hand.Add(card); }
        foreach (int card in foot.faceDown) { _hand.Add(card); }
        foreach (int card in _hand){
            if(card > 10){ _points += 10;
            } else if (card == 10) { _points += 20;
            } else { _points += card; }
        }
        return _points;
    }
    public List<int> getHand(){ return _hand; }
    public abstract List<int> play(int top);
}