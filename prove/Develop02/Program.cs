using System;

    class Program
    {
        static void Main(string[] args)
        {


            Write userFile = new Write();
            Read currentFile = new Read();
            Save openedfile = new Save();

            Random randomNum = new Random();

            bool quit = false;

            Console.WriteLine("Welcome to the Journal Program!");
       
            while (quit != true) {
                DisplayMenu();
                
                string userInput = Console.ReadLine();
                int answer = int.Parse(userInput);

                if (answer == 1) {
                    string writeDate = userFile.getCurrentDate();
                    int rndNumber = randomNum.Next(2);
                    
                    Console.WriteLine($"Date: {writeDate} - Prompt: {userFile._prompts[rndNumber]}");
                }
                else if (answer == 2) {
                    Console.WriteLine("Working 2");
                }
                else if (answer == 3)
                {
                Console.WriteLine("Working 3");
                }
                else if (answer == 4)
                {
                    Console.WriteLine("Working 4");
                }
                else if (answer == 5)
                {
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Working else");
                }
            }

            void DisplayMenu() {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");
            }
        
        }

    
    }


