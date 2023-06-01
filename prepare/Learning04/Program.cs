using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment A1 = new Assignment("Isaac Haws", "Coding");

        Console.WriteLine(A1.GetSummary());
        Console.WriteLine();

        
        MathAssignment MA1 = new MathAssignment("Colten Tanner", "Biology", "25.5", "8-19");

        Console.WriteLine(MA1.GetSummary());
        Console.WriteLine(MA1.GetHomeworkList());
        Console.WriteLine();


        WritingAssignment WA1 = new WritingAssignment("Tyler Jones", "Writing", "The Best Book Ever");

        Console.WriteLine(WA1.GetSummary());
        Console.WriteLine(WA1.GetWritingInformation());
    }
}