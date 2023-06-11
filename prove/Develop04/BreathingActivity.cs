
public class BreathingActivity : Activity 
{
    private string _breatheInMsg = "Breathe In...";
    private string _breatheOutMsg = "Now Breath Out...";

    
    public BreathingActivity(string name, string description): base(name, description) {
    }


    public void DisplayInOutMsg() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);
        
        while (DateTime.Now < endTime) {
            //Print Breathe In...
            Console.WriteLine("\n");
            Console.Write(_breatheInMsg); 
            
            //Display countdown
            this.PauseNCountdownTimer(5);
            
            //Print Breathe Out...
            Console.WriteLine();
            Console.Write(_breatheOutMsg);
            
            //Display countdown
            this.PauseNCountdownTimer(5);
        }
        Console.WriteLine();
    }
}