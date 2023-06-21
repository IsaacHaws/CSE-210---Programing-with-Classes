using System;


public class Goal {
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;

    public Goal() {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }


    protected string GetGoalName() {
        return _goalName;
    }

    protected string GetGoalDescription() {
        return _goalDescription;
    }

    protected int GetGoalPoints() {
        return _goalPoints;
    }



    public virtual int RecordGoal() {
        return _goalPoints;
    }

    public virtual void DisplayGoal(int num) {
        
    }

    public virtual bool IsComplete() {
        return false;
    }

}