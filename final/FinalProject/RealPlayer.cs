public class RealPlayer : Player {
    public override List<int> play() {
        int card = 0;
        while (true){
            displayHand();
            Console.Write("What card do you want to play? ");
            card = Int32.Parse(Console.ReadLine());
            bool test = _hand.Contains(card);
            if (_hand.Contains(card)){
                Console.Write("\nHow many would you like to play? ");
                int num = Int32.Parse(Console.ReadLine());
                List<int> temp = new List<int>();
                foreach (int j in _hand) { if (j == card) { temp.Add(j); } }
                if (temp.Count() >= num) { //if it is a legal play remove the cards from hand
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
    }
}