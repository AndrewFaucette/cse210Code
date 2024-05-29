public class Reference{
    private string _scriptReference;

    public void displayReference(){
        Console.Write(_scriptReference);
    }

    public string GetReference(){ return _scriptReference; }
    public void SetReference(string reference){ _scriptReference = reference; }

}