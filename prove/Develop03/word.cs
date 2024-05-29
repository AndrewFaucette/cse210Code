public class Word{
    private bool _visible = true;
    private bool _isNumber = false;
    private string _text;
    //private int _length = _text.Length;

    public void hide(){
        _visible = false;
    }
    public void displayWord(){
        if (_visible == true){
            Console.Write(_text);
        } else {
            for (int i = 0; i < _text.Length; i++){
                Console.Write("_");
            }
        }
    }

    public bool GetVisible(){ return _visible; }
    public void SetVisible(bool visible){ _visible = visible; }

    public bool GetIsNumber(){ return _isNumber; }
    public void SetIsNumber(bool isNumber){ _isNumber = isNumber; }

    public string GetText(){ return _text; }
    public void SetText(string text){ _text = text; }

    /*public int GetLength(){ return _length; }
    public void SetLength(int length){ _length = length; }*/
}