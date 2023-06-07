using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (quit != true) {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflection Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            int userInput = int.Parse(Console.ReadLine());


            switch (userInput)
            {
                case 1:
                    Console.WriteLine("case 1");
                    Activity activity = new Activity();
                    activity.PauseNSpinner();
                    break;

                case 2:
                    Console.WriteLine("case 2");
                    break;

                case 3:
                    Console.WriteLine("case 3");
                    break;

                case 4:
                    quit = true;
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid Answer! Try Again");
                    Console.WriteLine();
                    break;
            }
            





            
        }
    }
}