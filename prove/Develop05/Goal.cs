using System;


public class Goal {
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;

    //A construtor that asks for values
    public Goal() {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }

    //A constructor that get values through paramters
    public Goal(string name, string description, int points) {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
    }


    //Class methods
    public string GetGoalName() {
        return _goalName;
    }

    protected string GetGoalDescription() {
        return _goalDescription;
    }

    protected int GetGoalPoints() {
        return _goalPoints;
    }


    //Overide Methods
    public virtual int RecordGoal() {
        return _goalPoints;
    }

    //Print goal number, name, and description
    public virtual void DisplayGoal(int num) {
        Console.WriteLine($"{num}. [ ] {GetGoalName()} ({GetGoalDescription()})");
    }

    //Print Goal number and name
    public virtual void DisplayPartGoal(int num) {
        Console.WriteLine($"{num}. {GetGoalName()}");
    }

    //Method to return if goal is complete
    public virtual bool IsComplete() {
        return false;
    }

    //Method to write goal to file
    public virtual string WriteGoal() {
        return "";
    }
}