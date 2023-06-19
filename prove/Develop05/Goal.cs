using System;


public class Goal {
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;


    public Goal(string name, string description, int points) {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
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

    public virtual void DisplayGoal() {

    }

    public virtual bool IsComplete() {
        return false;
    }

}