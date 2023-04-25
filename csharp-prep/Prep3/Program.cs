using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1, 100);

        bool guessed = false;

        while (guessed != true) {
            Console.Write("What is your guess? ");
            string number_guess = Console.ReadLine();
            int guess = int.Parse(number_guess);

            
            if (guess == magic_num) {
                Console.WriteLine("You got it!");
                guessed = true;
            }

            else if (guess > magic_num) {
                Console.WriteLine("Lower");
            }

            else if (guess < magic_num) {
                Console.WriteLine("Higher");
            }
        }
    }
}