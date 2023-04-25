using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        int finished = 1;

        while (finished != 0) {
            Console.Write("Enter Number: ");
            int user_input = int.Parse(Console.ReadLine());

            if (user_input != 0) {
                numbers.Add(user_input);
            }

            else {
                finished = 0;
            }
        }
        
        //Calculate and print the sum
        int sum = 0;
        
        foreach (int number in numbers) {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        //Calculate and print the average
        int list_len = numbers.Count;
        int average = sum / list_len;

        Console.WriteLine($"The average is: {average}");


        //Calculate and print the largest number
        int greatest_number = 0;
        foreach (int number in numbers) {
            if (number > greatest_number) {
                greatest_number = number;
            }
        }

        Console.WriteLine($"The largest number is: {greatest_number}");

    }
}