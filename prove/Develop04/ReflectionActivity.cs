
public class ReflectionActivity : Activity 
{
    private string[] _prompts = {"Think of a time when you overcame a trial", 
    "Think of a time in your life when you did a act of service", 
    "Think of a time when you reflected the Savoir's light", 
    "Think of a time in your life when you learned an important lesson", 
    "Think of a time you did somthing for someone else"};
    
    private string[] _promptQuestions = {"How did this experience stregthen you testimony?", 
    "What have you learned from this experience?", 
    "How did you feel you handled this situation?", 
    "What did you like about this experience?", 
    "How did this experience streagthen your testimony?", 
    "How did you see the Lord's hand in this experience", 
    "Are you glad you had this experience?", 
    "How are you going to carry this knowledge into the future?", 
    "What did you learn about the Lord from this expereince", 
    "Who helped you during this experience?"};

    public ReflectionActivity(string name, string description): base(name, description) {
    }
    


    public string GetRandomPrompt() {
        //Declare Random method
        Random random = new Random();

        //Get random number within _prompt array length        
        int randomNum = random.Next(_prompts.Count());
        
        //Return prompt using random number
        return _prompts[randomNum];
    }

    public void DisplayPrompt(string prompt) {
        //Display prompt
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"  --- {prompt} ---");
        Console.WriteLine();

        Console.WriteLine("When you have somthing in mind, press enter to continue.");
        Console.ReadLine();
    }

    public string GetPromptQuestion() {
        //Declare Random method
        Random random2 = new Random();

        //Get random number within _promptQuestions array length 
        int randomPrompt = random2.Next(_promptQuestions.Count());
        
        //Return promptQuestion using random number
        return _promptQuestions[randomPrompt];
    }

    public void DisplayPromptQuestions(string question) {
        //Write ponder message
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        
        //Display Spinner
        this.PauseNCountdownTimer(5);

        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        //While current time is less than future time, print prompt question and get user input
        while (DateTime.Now < endTime) {
            string randomQuestion = this.GetPromptQuestion();
            Console.Write($"> {randomQuestion} ");
            this.PauseNSpinner(15);
            Console.WriteLine();
        }
    }
}