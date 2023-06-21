using System;


public class EternalGoal : Goal {



    public EternalGoal() {

    }

    // public EternalGoal(string name, string description, int points): base(name, description, points) {

    // }



    public override int RecordGoal() {
        return GetGoalPoints();
    }

    public override void DisplayGoal(int num) {
        Console.WriteLine($"{num}. [ ] {GetGoalName()} ({GetGoalDescription()})");
    }

    public override bool IsComplete() {
        return false;
    }
}