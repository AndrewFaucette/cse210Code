using System;

class Program {
    static void Main(string[] args) {
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
        Menu menu = new Menu();
        int current = 0;
        while (true) {
            Console.Write("1. play from your hand\n2. view the field\nWhat do you want to do? ");
            int option = Int32.Parse(Console.ReadLine());
            switch(option){
                case 1:
                    discard.play(players[current%numPlayers].play(), players[current%numPlayers]);
                    current++;
                    if (players[current%numPlayers].getHand().Count() < 1) {
                        Console.WriteLine("Round Over!");
                        deck.buildDeck(numPlayers);
                        deck.deal(players);
                    }
                    Console.WriteLine($"It is now player {option+1}'s turn");
                break;
                case 2:
                    menu.displayEverything(discard, players);
                break;
                default:
                    Console.WriteLine("Thats not a valid option");
                break;
            }
        }
    }
}