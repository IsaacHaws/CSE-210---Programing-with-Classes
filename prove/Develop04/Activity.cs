using System;

public class Activity {
    private string _activityName;
    private string _description;
    protected int _activityDuration;
    private string[] _animationString = {"/", "|", "\\", "-", "/", "|", "\\", "-"};


    
    public Activity(string name, string description) {
        _activityName = name;
        _description = description;
    }


    
    public void DisplayStartingMsg() {
        //Display activity name and description
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public int GetDuration() {
        //Write the question the the terminal
        Console.Write("How long, in seconds, would you like for you session? ");
        
        //Read answer and place it in a variable
        int answer = int.Parse(Console.ReadLine());
        
        //Return Variable 
        return answer;
    }

    public void setDuration(int activityTime) {
        //Set class variable to parameter value
        _activityDuration = activityTime;
    }

    public void DisplayGetReady() {
        //Clear console and print "Get Ready..."
        Console.Clear();
        Console.WriteLine("Get Ready...");
    }

    public void PauseNSpinner(int seconds) {
        DateTime spinStartTime = DateTime.Now;
        DateTime spinEndTime = spinStartTime.AddSeconds(seconds);
        
        //Declare variable and initalize it to 0
        int i = 0;
        
        //While current time is less then future time write spinner animation
        while (DateTime.Now < spinEndTime) {
            Console.Write(_animationString[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            //If i is greater then class variable length, set to 0
            if (i >= _animationString.Count()) {
                i = 0;
            }
        }
    }
    
    public void PauseNCountdownTimer(int seconds) {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        //Declare and initialize variable to method parameter
        int i = seconds;

        //While current time is less than future time, display countdown animation 
        while (DateTime.Now < endTime) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
    }

    public void DisplayEndMsg() {
        //Display first message
        Console.WriteLine("");
        Console.WriteLine("Well Done!!");
        
        //Dispaly spinner        
        this.PauseNSpinner(5);

        //Write second message
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName}");
        
        //Display spinner
        this.PauseNSpinner(8);
    }
}