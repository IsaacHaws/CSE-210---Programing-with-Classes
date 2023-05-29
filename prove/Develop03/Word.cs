using System;


public class Word {
    private string _word;
    private string _hiddenWord;
    private bool _hidden;


    public void Hide() {
        _word = _hiddenWord;
    }
    
    public void SetHiddenState() {
        _hidden = true;
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