public class ComPlayer : Player {
    //method to determine how the computer plays
    public override List<int> play(int top) {
        List<int> played = new List<int>();
        //This loop finds the hightest card in the computers hand that won't
        //result in picking up the deck and it adds all instances of the high
        //card to the "played" list
        int high = 0;
        foreach (int card in _hand){
            if (card > high && card <= top){
                played.Clear();
                high = card;
                played.Add(card);
            } else if (card == high) {
                played.Add(card);
            }
        }
        //if the above loop can't find a card that gets under the top card
        //it plays all of the highest card in hand
        if (high == 0){
            high = _hand[_hand.Count()-1];
            foreach (int card in _hand){
                if (card == high) {
                played.Add(card);
                }
            }
        }
        //removes the cards that get played from hand
        foreach (int card in played){ _hand.Remove(card); }
        return played;
    }
}