using System;


public class Prompt {
    private string _promptString = "Press enter to continue or type 'quit' to finish: ";

    
    public void DisplayPrompt() {
        Console.WriteLine();
        Console.Write(_promptString);
    }
    
    public string GetPromptAnswer() {
        string answer = Console.ReadLine();
        
        string output = "";
        
        ConsoleKeyInfo keyInfo;
        keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.Enter) {
            output = "hide";
        }
        else if (answer == "quit") {
            output = "quit";
        }
        
        return output;
    }
}