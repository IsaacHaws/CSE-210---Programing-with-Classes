using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment A1 = new Assignment("Isaac Haws", "Coding");

        Console.WriteLine(A1.GetSummary());

        
        MathAssignment MA1 = new MathAssignment("Colten Tanner", "Biology", "25.5", "8-19");

        Console.WriteLine(MA1.GetSummary());
        Console.WriteLine(MA1.GetHomeworkList());
    }
}