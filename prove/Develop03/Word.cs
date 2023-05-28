using System;


public class Word {
    public string _word;

    public bool _hidden;
    
    
    public void Hide() {
        for (int i = 0; i < _word.Length; i++)
        {
            _word = "_";
        }
    }

    public void Show() {
        
    }

    public void CheckIfHidden() {

    }

    public string GetRenderedWord() {
        return _word;
    }


    
    public Word() {
        _word = "";
        _hidden = false;
    }

    public Word(string selectedWord, bool hiddenStatus) {
        _word = selectedWord;
        _hidden = hiddenStatus;
    }
}