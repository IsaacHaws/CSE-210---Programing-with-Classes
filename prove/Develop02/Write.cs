using System;

public class Write {
    public string[] _prompts = {"What would you have done different today? ", 
    "What did you get done today? ", "How have you been blessed today? ", "Who did you talk with today? ", 
    "Name one peson you have talked to today", "What did you learn? "};

    public List<string> _entry = new List<string>();
    public string _currentDate;

    public string getCurrentDate() {
        DateTime fileDate = DateTime.Today;

        return fileDate.ToString("d");
    
    }
}