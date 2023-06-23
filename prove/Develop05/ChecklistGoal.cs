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

        Console.WriteLine();
    }

    public ChecklistGoal(string name, string description, int points, int bonusNum, int bonusAmount): base(name, description, points) {
        _bonusNum = bonusNum;
        _bonusAmount = bonusAmount;
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

            return GetGoalPoints();
        } 
    }

    public override void DisplayGoal(int num) {
        if (IsComplete() == false) {
            Console.WriteLine($"{num}. [ ] {GetGoalName()} ({GetGoalDescription()}) -- Currently Completed: {timesCompleted}/{GetBonusNumber()}");
        }
        else {
            Console.WriteLine($"{num}. [X] {GetGoalName()} ({GetGoalDescription()}) -- Currently Completed: {timesCompleted}/{GetBonusNumber()}");
        }
        
    }

    public override bool IsComplete() {
        if (timesCompleted >= GetBonusNumber()) {
            return true;
        }
        else {
            return false;
        }
    }

    public override string WriteGoal() {
        return $"ChecklistGoal:{GetGoalName()},{GetGoalDescription()},{GetGoalPoints()},{GetBonusNumber()},{GetBonusAmount()}";
    }
}