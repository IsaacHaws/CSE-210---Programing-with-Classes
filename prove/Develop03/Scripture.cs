using System;


public class Scripture {
    public List<Word> _scripture = new List<Word>();

    private string _reference;    
    
    public void HideWords() {
        Random randomWord = new Random();

        //How many words to hide
        int numWords = randomWord.Next(1, 4);

        //Hide "numWords" words
        for (int i = 0; i < numWords; i++)
        {  
            //Select random word in list to hide
            int randomHideWords = randomWord.Next(0, 32);
            
            foreach (Word item in _scripture)
            {
                
            }
            //string selectedWord = _scripture[randomHideWords]._word;
            //_scripture[randomHideWords]._word.Hide();
            
            //_scripture[randomHideWords]._word.Hide();
            
            _scripture[randomHideWords]._hidden = true;
            Console.WriteLine();
        }
    }

    public void DisplayScripture() {
        foreach (Word item in _scripture)
        {
            Console.Write(item._word + " ");
        }
        Console.WriteLine();
    }   

    public void CheckScripture() {
        
    }

    
    //Constructors
    public Scripture() {
        _scripture[0] = new Word(); 
        _reference = "none";
    }

    public Scripture(List<string> scripture, string reference) {
        foreach (string item in scripture)
        {
            _scripture.Add(new Word(item, false));
        }
    }
 }