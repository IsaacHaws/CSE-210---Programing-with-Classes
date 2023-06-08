
public class BreathingActivity : Activity 
{
    private string _breatheInMsg = "Breathe In...";
    private string _breatheOutMsg = "Breath Out...";

    
    public BreathingActivity(string name, string description): base(name, description) {
    }


    // public void DisplayBreathingInMsg() {
    //     //Print Breathe In...
    //     Console.WriteLine();
    //     Console.Write(_breatheInMsg); 
    // }

    // public void DisplayBreatheOutMsg() {
    //     //Print Breathe Out...
    //     Console.WriteLine();
    //     Console.Write(_breatheOutMsg);
    // }

    public void DisplayInOutMsg() {
        //Print Breathe In...
        Console.WriteLine();
        Console.Write(_breatheInMsg); 
        //Countdown
        this.PauseNCountdownTimer(5);
        
        //Print Breathe Out...
        Console.WriteLine();
        Console.Write(_breatheOutMsg);
        //Countdown
        this.PauseNCountdownTimer(5);
    }

}