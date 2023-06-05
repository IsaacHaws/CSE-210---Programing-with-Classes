using System;


public class Activity {
    private string _activityName;
    private string _description;
    private int _duration;
    private List<string> _animationString = new List<string>;
    private DateTime _currentTime;
    private int _animationTime;


    
    Activity() {
        _activityName = "blank";
        _description = "blank";
    }
    
    Activity(string name, string description) {
        _activityName = name;
        _description = description;
    }


    
    public void DisplayStartingMsg() {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_description);

    }

    public int GetDuration() {
        Console.Write("How long, in seconds, would you like for you session? ");
        int answer = int.Parse(Console.ReadLine());
        return answer;
    }

    public void PauseNSpinner() {

    }

    public void PauseNCountdownTimer() {

    }

    public void DisplayEndMsg() {
        Console.WriteLine("Well Done!!\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}");
    }
}