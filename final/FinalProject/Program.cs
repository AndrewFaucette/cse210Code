using System;

class Program {
    public static Discard discard = new Discard();
    public static List<Player> players = new List<Player>();
    static void Main(string[] args) {
        //get the number of real and computer players then put them in a list
        Console.Write("How many real players are there? ");
        int numReal = Int32.Parse(Console.ReadLine());
        Console.Write("How many com players are there? ");
        int numCom = Int32.Parse(Console.ReadLine());
        int numPlayers = numReal + numCom;
        for (int i = 0; i<numReal; i++){
            RealPlayer player = new RealPlayer();
            players.Add(player);
        }
        for (int i = 0; i<numCom; i++){
            ComPlayer player = new ComPlayer();
            players.Add(player);
        }
        //build the deck and deal ha hand to each player
        Deck deck = new Deck();
        deck.buildDeck(numPlayers);
        deck.deal(players);
        int current = 0;
        while (true) {
            //this series of functions performs each turn
            bool replay = discard.play(players[current%numPlayers].play(discard.top[0]), players[current%numPlayers]);
            Thread.Sleep(500);
            //if the player who just played has no cards in hand then the round ends and each player gets points
            if (players[current%numPlayers].getHand().Count() < 1) {
                Console.WriteLine("Round Over!");
                for (int i = 0; i<players.Count(); i++){
                    Console.WriteLine($"Player {i+1} has {players[i].addPoints()} points!");
                }
                //reset the game
                deck.buildDeck(numPlayers);
                deck.deal(players);
                current = 1;
                break;
            } else if (replay) {
                //except in the case of a swipe move to the next players turn
                current++;
                Console.WriteLine($"It is now player {current%numPlayers+1}'s turn");
            }
        }
    }
}