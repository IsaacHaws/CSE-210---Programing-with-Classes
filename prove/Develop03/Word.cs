using System;


public class Word {
    public string _word;
    private string _hiddenWord;
    private bool _hidden;


    public void Hide() {
        
    }

    public void Show() {
        
    }

    public bool CheckIfHidden() {
        if (_hidden == true) {
            return true;
        }
        else{
            return false;
        }
        
    }

    public string GetRenderedWord() {
        return _word;
    }


    
    public Word() {
        _word = "";
        _hiddenWord = "";
    }

    public Word(string selectedWord, string hiddenWord, bool hiddenState) {
        _word = selectedWord;
        _hiddenWord = hiddenWord;
        _hidden = hiddenState;
    }
}