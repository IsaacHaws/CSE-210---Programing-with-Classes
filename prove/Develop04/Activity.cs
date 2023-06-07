using System;


public class Activity {
    private string _activityName;
    private string _description;
    private int _duration;
    private string[] _animationString = {"+", "-", "#", "=", "_", "*"};
    private DateTime _currentTime = DateTime.Now;
    private int _animationTime = 10;


    
    public Activity() {
        _activityName = "";
        _description = "";
    }
    
    public Activity(string name, string description) {
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
        DateTime endtime = _currentTime.AddSeconds(_animationTime);
        
        int i = 0;
        
        while (DateTime.Now < endtime) {
            Console.Write(_animationString[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= _animationString.Count()) {
                i = 0;
            }
        }
    }
    
    public void PauseNCountdownTimer() {

    }

    public void DisplayEndMsg() {
        Console.WriteLine("Well Done!!\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}");
    }
}