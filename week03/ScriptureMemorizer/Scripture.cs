public class Scripture{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');

        foreach (string word in words){
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide){
        Random count = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide){
            int index = count.Next(_words.Count);

            if(!_words[index].IsHidden()){
                _words[index].Hide();
                hiddenCount++;
            }
        }

    }

    public string GetDisplayText(){
        
        List<string> words = new List<string>();

        foreach (Word word in _words){
            words.Add(word.GetDisplayText());
        }
        
        return _reference.GetDisplayText() + "- " + string.Join(" ", words);
    }

    public bool IsCompletelyHidden(){
        foreach (Word word in _words){
            if (!word.IsHidden()){
                return false;
            }
        }   
        return true;
    }
}