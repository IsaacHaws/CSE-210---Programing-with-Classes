using System;

public class Prompt {
    private string _promptString = "Press enter to continue or type 'quit' to finish: ";

    
    public void DisplayPrompt() {
        Console.WriteLine();
        Console.Write(_promptString);
        Console.WriteLine();
    }
    
    public string GetPromptAnswer() {
        string output = "";
        
        string answer = Console.ReadLine();
        
        if (answer == "quit") {
            output = "quit";
        }
        else{
            output = "";
        }
        
        return output;
    }
}