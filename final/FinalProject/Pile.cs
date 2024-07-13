public class Pile{
    List<int> _deck = new List<int>();

    public virtual void display(List<int> deck){
        foreach (int card in deck){
            Console.Write($"{card} ");
        }
        Console.WriteLine();
    }
}