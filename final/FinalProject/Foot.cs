public class Foot : Pile{
    public int[] faceUp = [0,0,0,0];
    public int[] faceDown = [0,0,0,0];

    public void setFoot(List<int> hand){
        //assigns the top 4 cards in the players hand to the face down piles
        for (int i=0; i<4; i++){
            faceDown[i] = hand[hand.Count()-1];
            hand.RemoveAt(hand.Count()-1);
        }
        //assigns the top 4 cards in the players hand to the face up piles
        for (int i=0; i<4; i++){
            faceUp[i] = hand[hand.Count()-1];
            hand.RemoveAt(hand.Count()-1);
        }
    }

    public override void display(List<int> deck){
        //displays the piles of the player
        for (int i = 0; i<4; i++){
            if (faceUp[i] == 0 && faceDown[i] == 0){
                Console.Write("[  ]");
            } else if (faceUp[i] == 0 && faceDown[i] != 0){
                Console.Write("[??]");
            } else if (faceUp[i] != 0){
                Console.Write($"[{faceUp[i]}]");
            } 
        }
        //Console.WriteLine();
    }
}