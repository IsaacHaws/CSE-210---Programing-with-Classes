using System;


public class Save {
    public string _editDate;
    public string _saveFilename;



    public string getCurrentTime() {
        DateTime date = DateTime.Today;

        return date.ToString("D");

    }


}