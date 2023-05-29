using System;

public class Scripture {
    private List<Word> _scripture = new List<Word>();

    private string _reference;   
    
    public void HideWords() {
        Random randomWord = new Random();
        
        //Get how many words to hide(1-3)
        int numWords = randomWord.Next(1, 4);

        //Hide "numWords" words
        for (int i = 0; i < numWords; i++)
        {  
            //Select random word in list to hide
            int randomHideWord = randomWord.Next(0, _scripture.Count());
            
            //Check if word is hidden
            bool wordHiddenState = _scripture[randomHideWord].CheckIfHidden();
            
            //If it is not hidden, hide the word using the hide method
            //and set the _hiddenState to true
            if (wordHiddenState == false) {
                _scripture[randomHideWord].Hide();
                _scripture[randomHideWord].SetHiddenState();
            }
            //Else add 1 to the numWords var so the for loop can hide another word
            else{
                numWords += 1;
            } 
        }
    }

    public void DisplayScripture() {
        //Clear the console and iterate through the _scripture variable
        //and print eachword with a space
        Console.Clear();
        Console.Write(_reference + " ");
        foreach (Word item in _scripture)
        {   
            Console.Write(item.GetRenderedWord() + " ");
        }
        Console.WriteLine();
    }   

    public bool CheckScripture() {
        int hiddenNum = 0;
        
        //Check if each Word item is hidden 
        foreach (Word item in _scripture)
        {
            //If hidden add 1 to the variable
            if (item.CheckIfHidden() == true) {
                hiddenNum += 1;
            }
        }
        
        //If the number of hidden words is equel to the number of words in the list return true
        if (hiddenNum == _scripture.Count()) {
            return true;
        }
        //Else false
        else{
            return false;
        }
    }

    
    //Constructors
    public Scripture() {
        _scripture[0] = new Word(); 
        _reference = "";
    }

    public Scripture(List<string> scripture, string reference) {
        //Iterate through input scripture
        foreach (string item in scripture)
        {   
            //Get word length
            int wordLength = item.Length;
            string underScore;
            
            switch (wordLength)
            {   
                case 1:
                    underScore = "_";
                    break;
                case 2:
                    underScore = "__";
                    break;
                case 3:
                    underScore = "___";
                    break;
                case 4:
                    underScore = "____";
                    break;
                case 5:
                    underScore = "_____";
                    break;
                case 6:
                    underScore = "______";
                    break;
                case 7:
                    underScore = "_______";
                    break;
                case 8:
                    underScore = "________";
                    break;
                case 9:
                    underScore = "_________";
                    break;
                case 10:
                    underScore = "__________";
                    break;
                case 11:
                    underScore = "___________";
                    break;
                case 12:
                    underScore = "____________";
                    break;
                case 13:
                    underScore = "_____________";
                    break;
                case 14:
                    underScore = "______________";
                    break;
                case 15:
                    underScore = "_______________";
                    break;
                
                default:
                    underScore = "";
                    break;
            }
            
            _scripture.Add(new Word(item, underScore, false));
        }
        _reference = reference;
    }
 }