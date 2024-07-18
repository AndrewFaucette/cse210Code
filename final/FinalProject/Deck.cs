using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Deck: Pile{
    List<int> _deck = new List<int>();
    List<int> _discard = new List<int>();

    //takes the number of players and adds cards to the deck appropriate for the number of players.
    public void buildDeck(int players){
        _deck.Clear();
        int decksNeeded = ((19*players)/54)+1;
        for(int i = 1; i<14; i++){
            for(int j = 0; j<decksNeeded*4; j++){
                _deck.Add(i);
            }
        }
    }
    public void deal(List<Player> players){
        int num = players.Count();
        //create a list of lists each being one player's hand
        List<List<int>> hands = new List<List<int>>();
        for (int i = 0; i<num; i++){
            List<int> hand = new List<int>();
            hands.Add(hand);
        }
        //deals a random card from the deck to each player 19 times
        for (int j = 0; j<19; j++){
            foreach (List<int> hand in hands){
                Random random = new Random();
                int index = random.Next(0,_deck.Count);
                hand.Add(_deck[index]);
                _deck.RemoveAt(index);
            }
        }
        //organize each players hand
        foreach (Player player in players){
            player.setHand(hands[0], true);
            hands.RemoveAt(0);
        }
    }
}