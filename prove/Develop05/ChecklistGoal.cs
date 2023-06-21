using System;


public class ChecklistGoal : Goal {
    private int _bonusNum;
    private int _bonusAmount;
    private int timesCompleted;


    public ChecklistGoal() {
        Console.Write("How many times does this goal need to accomplished for a bonus? ");
        _bonusNum = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusAmount = int.Parse(Console.ReadLine());
    }
    


    protected int GetBonusNumber() {
        return _bonusNum;
    }

    protected int GetBonusAmount() {
        return _bonusAmount;
    }



    public override int RecordGoal() {
        timesCompleted++;
        if (IsComplete() == true) {
            int bonusPoints = GetGoalPoints() + GetBonusAmount();
            Console.WriteLine($"Congradulations! You have earned {bonusPoints} points!");
            
            return bonusPoints;
        }
        
        else {
            Console.WriteLine($"Congradulations! You have earned {GetGoalPoints()} points!");
            timesCompleted++;

            return GetGoalPoints();
        } 
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