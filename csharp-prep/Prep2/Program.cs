using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string user_input = Console.ReadLine();
        
        int percentage = int.Parse(user_input);
        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }

        else if (percentage >= 80) 
        {
            letter = "B";
        }

        else if (percentage >= 70) 
        {
            letter = "C";
        }

        else if (percentage >= 60) 
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        
        Console.WriteLine($"Your grade is: {letter}");

       
        if (percentage > 70)
        {
            Console.WriteLine("You Passed the Class!!");
        }

        else
        {
            Console.WriteLine("Sorry, you did not pass. You will make it next time!");
        }
        
    }
}