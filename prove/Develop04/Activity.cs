using System;


public class Activity {
    private string _activityName;
    private string _description;
    private int _activityDuration;
    private string[] _animationString = {"+", "-", "#", "=", "_", "*"};
    private DateTime _currentTime = DateTime.Now;
    private int _animationTime = 10;


    
    public Activity(string name, string description) {
        _activityName = name;
        _description = description;
    }


    
    public void DisplayStartingMsg() {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public int GetDuration() {
        Console.Write("How long, in seconds, would you like for you session? ");
        int answer = int.Parse(Console.ReadLine());
        return answer;
    }

    public void setDuration(int activityTime) {
        _activityDuration = activityTime;
    }

    public void DisplayGetReady() {
        Console.Clear();
        Console.WriteLine("Get Ready...");
    }

    public void PauseNSpinner(int seconds) {
        DateTime spinStartTime = DateTime.Now;
        DateTime spinEndTime = spinStartTime.AddSeconds(seconds);
        
        int i = 0;
        
        while (DateTime.Now < spinEndTime) {
            Console.Write(_animationString[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= _animationString.Count()) {
                i = 0;
            }
        }
    }
    
    public void PauseNCountdownTimer(int seconds) {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
         
        int i = seconds;

        while (DateTime.Now < endTime) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
    }

    public void DisplayEndMsg() {
        Console.WriteLine("\n");
        Console.WriteLine("Well Done!!");
        this.PauseNSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName}");
        this.PauseNSpinner(8);
    }
}