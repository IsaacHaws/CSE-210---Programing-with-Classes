using System;


public class EternalGoal : Goal {



    public EternalGoal(string name, string description, int points): base(name, description, points) {

    }



    public override int RecordGoal() {
        return GetGoalPoints();
    }

    public override void DisplayGoal() {

    }

    public override bool IsComplete() {
        return false;
    }
}