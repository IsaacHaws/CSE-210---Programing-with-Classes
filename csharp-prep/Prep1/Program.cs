using System;

class Program
{
    static void Main(string[] args) {
        //Ask for the first name
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        //Ask for the last name
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine();

        //Print the classic saying
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");
    }
}