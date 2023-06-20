using System;


public class ChecklistGoal : Goal {
    private int _bonusNum;
    private int _bonusAmount;
    private int timesCompleted;


    public ChecklistGoal(string name, string description, int points, int times, int bonusAmount): base(name, description, points) {
        _bonusNum = times;
        _bonusAmount = bonusAmount;
    }


    protected int GetBonusNumber() {
        return _bonusNum;
    }

    protected int GetBonusAmount() {
        return _bonusAmount;
    }



    public override int RecordGoal() {
        return GetGoalPoints();
    }

    public override void DisplayGoal(int num) {
        Console.WriteLine($"{num}. [ ] {GetGoalName()} ({GetGoalDescription()}) -- Currently Completed: {timesCompleted}/{GetBonusNumber()}");
    }

    public override bool IsComplete() {
        if (timesCompleted >= GetBonusNumber()) {
            return true;
        }
        else {
            return false;
        }
    }
}