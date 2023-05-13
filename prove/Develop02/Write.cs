using System;
using System.IO;

public class Write {
    public string[] _prompts = {"What would you have done different today", "What did you get done today"};
    public string _filename;
    public string _currentDate;








    public string getCurrentDate() {
        DateTime fileDate = DateTime.Today;

        return fileDate.ToString("d");
    
    }
}