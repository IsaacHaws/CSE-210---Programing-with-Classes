
public class ReflectionActivity : Activity 
{
    private string[] _prompts = {"prompt1", "prompt2", "prompt3", "prompt4"};
    private string[] _promptQuestions = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", 
    "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", 
    "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public ReflectionActivity(string name, string description): base(name, description) {
    }
    


    public string GetRandomPrompt() {
        Random random = new Random();
        int randomNum = random.Next(4);
        return _prompts[randomNum];
    }

    public void DisplayPrompt(string prompt) {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"  --- {prompt} ---");
        Console.WriteLine();

        Console.WriteLine("When you have somthing in mind, press enter to continue.");
        Console.ReadLine();
    }

    public string GetPromptQuestion() {
        Random random2 = new Random();
        int randomPrompt = random2.Next(10);
        return _promptQuestions[randomPrompt];
    }

    public void DisplayPromptQuestion(string question) {
        
    }





}