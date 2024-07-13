public class Discard : Pile{
    List<int> discard = new List<int>();
    List<int> top = new List<int>{0};

    public void play(List<int> cards, Player player){
        //if the cards played are the same number as the card on the top of the pile it adds to that list
        if (cards[0] == top[0]) {
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
            }
            top.Clear();
            foreach (int card in cards) {
                discard.Add(card);
                top.Add(card);
            }
        }
        //checks to see if the played cards constitutes a swipe
        if (top[0] == 10 || top.Count() > 3){
            swipe();
        } else {
            Console.WriteLine($"{top.Count()} {top[0]}s!");
        }
    }
    public void swipe(){
        discard.Clear();
        top.Clear();
        Console.WriteLine("!!!SWIPE!!!");
    }
    public List<int> getDiscard(){ return discard; }
}