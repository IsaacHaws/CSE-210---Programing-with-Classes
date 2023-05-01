using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1996;
        job1._endYear = 2010;


        Job job2 = new Job();
        job2._jobTitle = "Teacher";
        job2._company = "Kids Zone";
        job2._startYear = 2022;
        job2._endYear = 2024;

        
        Resume myResume = new Resume();
        myResume._name = "Isaac Haws";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        
        myResume.Display();

    }
}