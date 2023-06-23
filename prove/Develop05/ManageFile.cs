using System.IO;

public class ManageFile {
    private string _filename;
    private string[] _lines;
    private string _name;
    private string _description;
    private int _points;
    private string _action;
    private string _goalType;


    public ManageFile(List<Goal> goals, int points, string action) {
        Console.WriteLine();
        Console.Write("What is the filename for the goal file? ");
        _filename = Console.ReadLine();

        Console.WriteLine();

        _points = points;
        _action = action;

        if (_action == "save") {
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {   
                outputFile.WriteLine(_points);
                foreach (Goal goal in goals)
                {
                   outputFile.WriteLine(goal.WriteGoal());
                }
            }
        } 

        else if (_action == "load") {
            string[] lines = System.IO.File.ReadAllLines(_filename);

            foreach (string line in lines)
            {
                string[] splitParts = line.Split(":");

                _goalType = splitParts[0];
                string goalInfo = splitParts[1];

                
                string[] parts = goalInfo.Split(",");
                
                _name = parts[0];
                _description = parts[1];
                _points = int.Parse(parts[2]);

                if (_goalType == "ChecklistGoal") {
                    int bonustimes = int.Parse(parts[3]);
                    int bonusNum = int.Parse(parts[4]);

                    AddGoal(goals, _name, _description, _points, bonustimes, bonusNum);
                }
                else {
                    AddGoal(goals, _name, _description, _points);
                }
            }
        }
    }

    public void AddGoal(List<Goal> goals, string name, string description, int points, int times = 0, int bonusAmount = 0) {
        if (_goalType == "SimpleGoal") {
            goals.Add(new SimpleGoal(name, description, points, false));
        }
        else if (_goalType == "EternalGoal") {
            goals.Add(new EternalGoal(name, description, points));
        }
        else if (_goalType == "ChecklistGoal") {
            goals.Add(new ChecklistGoal(name, description, points, times, bonusAmount));
        }   
    }
}