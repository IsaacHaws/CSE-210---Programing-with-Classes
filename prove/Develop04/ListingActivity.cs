
public class ListingActivity : Activity 
{
    private string[] _promptList = {"When have you been happy this month?", 
    "What have you done to come closer to the lord?", 
    "What songs have you listened to in the past week", 
    "Who have you uplifted in the past week", 
    "Where in your life have you invited the Holy Ghost to come", 
    "Where have you put others first in your life"};
    private int _promptNum;
    private string _userInput;

    public ListingActivity(string name, string description): base(name, description) {
    }


    public string GetRandomPrompt() {
        Random random = new Random();
        int randomNum = random.Next(_promptList.Count());
        return _promptList[randomNum];
    }

    public void DisplayPrompt(string prompt) {
        Console.WriteLine();
        
        Console.WriteLine("List as many responses to the following prompt:");
        Console.WriteLine($" --- {prompt} ---");
        
        Console.Write("You may begin in: ");
        this.PauseNCountdownTimer(5);
        Console.WriteLine();
    }

    public void GetPromptAnswer() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);
        
        _promptNum = 0;

        while (DateTime.Now < endTime) {
            Console.Write("> ");
            string answer = Console.ReadLine();
            _promptNum++;
        }
        Console.WriteLine($"You listed {_promptNum} items!");
    }
}