using System;
using System.IO;

public class ManageFile {
    private string _filename;
    private string[] _lines;
    private int _goalIndex;
    private int _nameIndex;
    private int _descriptionIndex;
    private int _pointsIndex;
    private string _action;


    public ManageFile(string action) {
        Console.WriteLine();
        Console.Write("What is the filename for the goal file? ");
        _filename = Console.ReadLine();

        _action = action;

        if (_action == "save") {
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"");
    
                // You can use the $ and include variables just like with Console.WriteLine
                string color = "Blue";
                outputFile.WriteLine($"My favorite color is {color}");
            }
        } 

        else if (_action == "load") {
            string[] lines = System.IO.File.ReadAllLines(_filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                _goalIndex = int.Parse(parts[0]);
                _nameIndex = int.Parse(parts[1]);
                _descriptionIndex = int.Parse(parts[2]);
                _pointsIndex = int.Parse(parts[3]);
            }
        }

    }








}