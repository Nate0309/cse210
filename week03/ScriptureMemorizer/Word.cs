public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string text){
        _text = text;
        _isHidden = false;
    }

    public void Hide(){
        string hiddenWord = new string('_', _text.Length);
        _text = hiddenWord;
        _isHidden = true;
    }

    public void Show(){
        Console.WriteLine(_text);
    }

    public bool IsHidden(){
        return _isHidden;
    }

    public string GetDisplayText(){
        return _text;
    }
}