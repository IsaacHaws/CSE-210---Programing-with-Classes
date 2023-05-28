using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> inputScripture = new List<string> {"Be", "strong", "and", "of", "good", "courage,", 
        "fear", "not,", "nor", "be", "afraid:", "for", "the", "Lord", "thy", "God,", "he", "it", "is", "that", 
        "doth", "go", "with", "thee;", "he", "will", "not", "fail", "thee", "nor", "forsake", "thee."};

        string inputReference = "Deuteronomy 31:6";

        bool quit = false;


        while (quit != true) {
            Scripture scripture = new Scripture(inputScripture, inputReference);
            Prompt userPrompt = new Prompt();

            scripture.DisplayScripture();
            userPrompt.DisplayPrompt();

            string userAnswer = userPrompt.GetPromptAnswer();
            
            if (userAnswer == "hide") {
                scripture.HideWords();
            }
            else if (userAnswer == "quit") {
                quit = true;
            }
        } 
    }
}