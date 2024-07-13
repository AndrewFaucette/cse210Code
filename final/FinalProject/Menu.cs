public class Menu {
    /*public void startGame(){
        List<Player> players = new List<Player>();
        Console.Write("How many players are there? ");
        int numPlayers = Int32.Parse(Console.ReadLine());
        for (int i = 0; i<numPlayers; i++){
            RealPlayer player = new RealPlayer();
            players.Add(player);
        }
        Deck deck = new Deck();
        deck.buildDeck(numPlayers);
        deck.deal(players);
        Discard discard = new Discard();
    }*/
    public void displayEverything(Discard discard, List<Player> players) {
    //display each player's piles, how many cards in their hand, and the discard
    List<int> deck = new List<int>();
        for (int i = 0; i < players.Count(); i++) {
            Console.Write($"{i+1}. ");
            players[i].foot.display(deck);
            Console.WriteLine($" cards left: {players[i].getHand().Count()}");
        }
        discard.display(discard.getDiscard());
    }
}