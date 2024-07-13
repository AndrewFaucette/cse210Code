public class Foot : Pile{
    int[] faceUp = [0,0,0,0];
    int[] faceDown = [0,0,0,0];
    List<int> temp = new List<int>();

    public void setFoot(List<int> hand){
        for (int i=0; i<4; i++){
            faceDown[i] = hand[hand.Count()-1];
            hand.RemoveAt(hand.Count()-1);
        }
        for (int i=0; i<4; i++){
            faceUp[i] = hand[hand.Count()-1];
            hand.RemoveAt(hand.Count()-1);
        }
        //display(temp);
    }

    public override void display(List<int> deck){
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