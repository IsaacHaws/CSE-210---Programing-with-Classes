using System;


public class SimpleGoal : Goal {
    private bool _completed;



    public SimpleGoal(bool completed){
        _completed = completed;
    }

    // public SimpleGoal(string name, string description, int points, bool completed): base(name, description, points) {
    //     _completed = completed;
    // }

    

    public override int RecordGoal() {
        _completed = true;
        Console.WriteLine($"Congradulations! You have earned {GetGoalPoints()} points!");
        
        return GetGoalPoints();
    }

    public override void DisplayGoal(int num) {
        if (IsComplete() == true) {
            Console.WriteLine($"{num}. [X] {GetGoalName()} ({GetGoalDescription()})");
        }

        else {
            Console.WriteLine($"{num}. [ ] {GetGoalName()} ({GetGoalDescription()})");
        }
        
    }

    public override bool IsComplete() {
        if (_completed == true) {
            return true;
        }
        else {
            return false;
        }
    }
}