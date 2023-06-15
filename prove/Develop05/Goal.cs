using System;


public class Goal {
    private string _goalName = "give a talk";
    private string _goalDescription = "talk in church";


    protected string GetGoalName() {
        return _goalName;
    }

    public virtual void DisplayGoal() {
        Console.WriteLine($"1. [ ] {_goalName}");
    }

}