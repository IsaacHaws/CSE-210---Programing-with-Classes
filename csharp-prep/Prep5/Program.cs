using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int number = PromptUserNumber();

        int square_number = SquareNumber(number);

        DisplayResult(square_number, name);




        static void DisplayWelcome() {  
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName() {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber() {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber(int num) {
            int sq_num = num * num;

            return sq_num;
        }

        static void DisplayResult(int sq_num, string name) {
            Console.WriteLine($"{name}, the square of your number is {sq_num}");
        }
    }
}