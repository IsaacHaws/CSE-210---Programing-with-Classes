using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        //Declare classes
        Write userFile = new Write();
        Read currentFile = new Read();
        Save openedfile = new Save();

        Random randomNum = new Random();

        bool quit = false;

        Console.WriteLine("Welcome to the Journal Program!");

        while (quit != true)
        {
            DisplayMenu();

            int answer = int.Parse(Console.ReadLine());
            
            //Write
            if (answer == 1)
            {
                //Get current date
                userFile._currentDate = userFile.getCurrentDate();
                
                //Get a random number
                int rndNumber = randomNum.Next(6);
                
                //Use random number to retreve prompt
                string prompt = userFile._prompts[rndNumber];

                //Write prompt for user to see
                Console.WriteLine(prompt);
                Console.Write("> ");
                
                //Read and store answer
                string promptAnswer = Console.ReadLine();

                //Create an entry that will later be saved to a file  
                userFile._entry.Add($"Date: {userFile._currentDate} - Prompt: {prompt}\n" +
                $"{promptAnswer}\n");    
            }
            
            //Display
            else if (answer == 2)
            {   
                foreach (string item in userFile._entry)
                {  
                    Console.WriteLine(item);
                }
            
            }
            
            //Load
            else if (answer == 3)
            {
                //Retreve the filename
                Console.Write("What is the filename? ");
                currentFile._readFilename = Console.ReadLine();

                currentFile._lines = System.IO.File.ReadAllLines(currentFile._readFilename);

                //Read file
                foreach (string line in currentFile._lines)
                {
                   Console.WriteLine(line);
                }
            }
            
            //Save
            else if (answer == 4)
            {
                //Retreve the filename
                Console.Write("What is the filename? ");
                openedfile._saveFilename = Console.ReadLine();
                
                //Write file
                using (StreamWriter outputFile = new StreamWriter(openedfile._saveFilename))
                {
                    foreach (string line in userFile._entry)
                    {
                        outputFile.WriteLine(line);
                    }
                }
            }
            
            //Quit
            else if (answer == 5)
            {
                Console.WriteLine("Goodbye");
                quit = true;
            }
            

            else
            {
                Console.WriteLine("Invalid Answer! Try Again");
            }
        }

        
        
        void DisplayMenu()
        {
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