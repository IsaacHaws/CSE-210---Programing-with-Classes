using System;


public class SimpleGoal : Goal {
    private bool _completed;


    public SimpleGoal(string name, string description, int points, bool completed): base(name, description, points) {
        _completed = completed;
    }

    

    public bool GetCompletedState() {
        return _completed;
    }



    public override int RecordGoal() {
        return GetGoalPoints();
    }

    public override void DisplayGoal() {
        if (_completed == true) {
            Console.Write($"1. [X] {GetGoalName()} ({GetGoalDescription()})");
        }

        else {
            Console.Write($"1. [ ] {GetGoalName()} ({GetGoalDescription()})");
        }
        
    }

    public override bool IsComplete() {
        return false;
    }
}