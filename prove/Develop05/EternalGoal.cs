using System;


public class EternalGoal : Goal {

    
    public EternalGoal() {
        Console.WriteLine();
    }
    
    public EternalGoal(string name, string description, int points): base(name, description, points) {
        
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

    public override string WriteGoal() {
        return $"EternalGoal:{GetGoalName()},{GetGoalDescription()},{GetGoalPoints()}, {IsComplete()}";
    }
}