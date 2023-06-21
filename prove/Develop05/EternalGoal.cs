using System;


public class EternalGoal : Goal {



    public EternalGoal() {

    }


    public override int RecordGoal() {
        Console.WriteLine($"Congradulations! You have earned {GetGoalPoints()} points!");
        
        return GetGoalPoints();
    }

    public override void DisplayGoal(int num) {
        Console.WriteLine($"{num}. [ ] {GetGoalName()} ({GetGoalDescription()})");
    }

    public override bool IsComplete() {
        return false;
    }
}