using System.IO;

public class ManageFile {
    private string _filename;
    private string[] _lines;
    private string _goalType;
    private string _goalInfo;
    private string _name;
    private string _description;
    private int _goalPoints;
    private int _totalPoints;
    private string _action;
    


    public ManageFile(List<Goal> goals, int totalPoints, string action) {
        //Get file name
        Console.WriteLine();
        Console.Write("What is the filename for the goal file? ");
        _filename = Console.ReadLine();

        Console.WriteLine();

        _totalPoints = totalPoints;
        _action = action;

        
        //If _action is equel to "save" save goals to given file
        if (_action == "save") {
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {    
                //Write the number of points to file 
                outputFile.WriteLine(_totalPoints);
                
                //Iterate through goals list and write them to the file
                foreach (Goal goal in goals)
                {
                   outputFile.WriteLine(goal.WriteGoal());
                }
            }
        } 

        
        //if _action is equel to "load" read lines from selected file
        //and append new goals to goals list
        else if (_action == "load") {
            _lines = System.IO.File.ReadAllLines(_filename);

            //Set firstLine to true
            bool firstLine = true;

            foreach (string line in _lines)
            {   
                //If firstLine is true, get totalPoints
                if (firstLine == true) {
                    _totalPoints = int.Parse(line);
                    
                    //Turn firstLine to false
                    firstLine = false;
                    
                    //Skip to next line
                    continue;
                }

                //On every other line first split string by ":" to get the goal type and goal information
                string[] splitParts = line.Split(":");

                //Get the goalType and goalInfo by index
                _goalType = splitParts[0];
                _goalInfo = splitParts[1];

                //And then split the goal information by "," to get the nedded values
                string[] parts = _goalInfo.Split(",");
                
                //Get values by index
                _name = parts[0];
                _description = parts[1];
                _goalPoints = int.Parse(parts[2]);
                bool completed = bool.Parse(parts[3]);

                //If the goal type is "ChecklistGoal", get three extra values.
                //1. How many times the goal needs to be completed
                //2. How many times it has been completed
                //3. The number of bonus points when completed
                if (_goalType == "ChecklistGoal") {
                    int bonustimes = int.Parse(parts[4]);
                    int timesCompleted = int.Parse(parts[5]);
                    int bonusNum = int.Parse(parts[6]);

                    //Add a new goal to the goals list with the information gained by spliting the current line
                    //including the the 3 extra values
                    AddGoal(goals, _name, _description, _goalPoints, completed, bonustimes, timesCompleted, bonusNum);
                }
                else {
                    //Add a new goal to the goals list with the information gained by spliting the current line
                    AddGoal(goals, _name, _description, _goalPoints, completed);
                }
            }
        }
    }


    public int GetTotalPoints() {
        return _totalPoints;
    }
    
    public void AddGoal(List<Goal> goals, string name, string description, int points, bool completed = false, int times = 0, int timesCompleted = 0, int bonusAmount = 0) {
        //If _goalType equels SimpleGoal, add SimpleGoal to goals list with parameters
        if (_goalType == "SimpleGoal") {
            goals.Add(new SimpleGoal(name, description, points, completed));
        }
        else if (_goalType == "EternalGoal") {
            goals.Add(new EternalGoal(name, description, points));
        }
        else if (_goalType == "ChecklistGoal") {
            goals.Add(new ChecklistGoal(name, description, points, times, timesCompleted, bonusAmount));
        }   
    }
}