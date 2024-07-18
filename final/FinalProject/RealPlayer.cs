public class RealPlayer : Player {

    Menu menu = new Menu();
    public override List<int> play(int top) {
        while(true){
            //The player can choose what to do on their turn but it doesn't end until they play a card
            Console.Write("\n1. play from your hand\n2. view the field\nWhat do you want to do? ");
            int option = Int32.Parse(Console.ReadLine());
            switch(option){
            //if the player chooses to play then they choose what cards to play from their hand
                case 1:
                    while (true){
                        //ask which card the player wants to play and finds out if they can play it
                        displayHand();
                        Console.Write("What card do you want to play? ");
                        int card = Int32.Parse(Console.ReadLine());
                        if (_hand.Contains(card)){
                            Console.Write("How many would you like to play? ");
                            int num = Int32.Parse(Console.ReadLine());
                            List<int> temp = new List<int>();
                            foreach (int j in _hand) { if (j == card) { temp.Add(j); } }
                            //if it is a legal play remove the cards from hand
                            if (temp.Count() >= num) {
                                List<int> played = new List<int>();
                                for (int i = 0; i < num; i++){
                                    played.Add(card);
                                    _hand.Remove(card);
                                }
                                return played;
                            } else {
                                Console.WriteLine($"\nYou don't have {num} {card}s");
                            }
                        } else {
                            Console.WriteLine("\nYou don't have that card");
                        }
                    }
                case 2:
                    menu.displayEverything(Program.discard, Program.players);
                    break;
                default:
                    Console.WriteLine("Thats not a valid option");
                    break;
            }
        }
    }
}