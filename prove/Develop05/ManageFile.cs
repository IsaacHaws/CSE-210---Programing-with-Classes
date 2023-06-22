using System.IO;

public class ManageFile {
    private string _filename;
    private string[] _lines;
    private int _nameIndex;
    private int _descriptionIndex;
    private int _pointsIndex;
    private string _action;


    public ManageFile(List<Goal> goals, string action) {
        Console.WriteLine();
        Console.Write("What is the filename for the goal file? ");
        _filename = Console.ReadLine();

        Console.WriteLine();

        _action = action;

        if (_action == "save") {
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {   

            }
        } 

        else if (_action == "load") {
            string[] lines = System.IO.File.ReadAllLines(_filename);

            foreach (string line in lines)
            {
                string[] splitParts = line.Split(":");

                string goalType = splitParts[0];
                string goalInfo = splitParts[1];

                
                string[] parts = goalInfo.Split(",");
                
                
                _nameIndex = int.Parse(parts[0]);
                _descriptionIndex = int.Parse(parts[1]);
                _pointsIndex = int.Parse(parts[2]);

                
            }
        }
    }


    public void AddGoal(int totalPoints, string name, string description, int goalPoints) {
        
    }



    public string GetName() {
        return "";
    }

    public string GetDescription() {
        return "";
    }

    public int GetPoints() {
        return 0;
    }
}