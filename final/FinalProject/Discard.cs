public class Discard : Pile{
    private List<int> discard = new List<int>();
    public List<int> top = new List<int>{0};

    public bool play(List<int> cards, Player player){
        bool replay = false;
        //If the player played a ten they swipe
        if (cards[0] == 10) {
            swipe();
            Console.WriteLine($"{cards.Count()} 10s!");
            return false;
        //if the cards played are the same number as the card on the top of the pile it adds to that list
        } else if (cards[0] == top[0]) {
            foreach (int card in cards) {
                discard.Add(card);
                top.Add(card);
            }
        //if the cards played don't match the top card then it clears the top and sets it to the cards played
        } else {
            //if the cards played are greater than the top the player gets the discard pile
            if (cards[0] > top[0]) {
                List<int> temp = new List<int>(player.getHand());
                foreach (int card in discard) { temp.Add(card); }
                player.setHand(temp);
                discard.Clear();
                //even if the player plays 4 of the same card if they are forced to pick up the pile they don't swipe
                replay = true;
            }
            top.Clear();
            //add the cards played to the top and discard
            foreach (int card in cards) {
                discard.Add(card);
                top.Add(card);
            }
        }
        Console.WriteLine($"{top.Count()} {top[0]}s!");
        //checks to see if the played cards constitutes a swipe
        if (top.Count() > 3){
            swipe();
            return replay;
        } else {
            return true;
        }
    }
    public void swipe(){
        discard.Clear();
        top.Clear();
        top.Add(0);
        Console.WriteLine("!!!SWIPE!!!");
    }
    public List<int> getDiscard(){ return discard; }
}