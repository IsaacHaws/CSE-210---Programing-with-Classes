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

    public Goal(string name, string description, int points) {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
    }


    public string GetGoalName() {
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
        Console.WriteLine($"{num}. [ ] {GetGoalName()} ({GetGoalDescription()})");
    }

    public virtual void DisplayPartGoal(int num) {
        Console.WriteLine($"{num}. {GetGoalName()}");
    }

    public virtual bool IsComplete() {
        return false;
    }

    public virtual string WriteGoal() {
        return "";
    }
}