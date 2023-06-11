using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (quit != true) {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflection Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {   
                //Breathing Activity
                case 1:
                    //Clear Console
                    Console.Clear();
                    //Declare breathing class
                    BreathingActivity breathe = new BreathingActivity("Breathing Activity", "This activity will help you slow down and relax by guiding you through a breathing exercise");
                    
                    //Display welcoming message
                    breathe.DisplayStartingMsg();
                    
                    //Get and set the duration of the activity
                    breathe.setDuration(breathe.GetDuration());
                    
                    //Dispaly Get Ready... Message
                    breathe.DisplayGetReady();
                    
                    //Spin
                    breathe.PauseNSpinner(6);

                    //Display breathing messages and spinners
                    breathe.DisplayInOutMsg();

                    //Display end message
                    breathe.DisplayEndMsg();
                    break;
                
                
                //Reflection Activity
                case 2:
                    //Clear Console
                    Console.Clear();
                    //Declare reflecting class
                    ReflectionActivity reflect = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on the past experiences in your life that have given you knowledge,\nstreagth or power.");
                    
                    //Display welcoming message
                    reflect.DisplayStartingMsg();
                    
                    //Get and set the duration of the activity
                    reflect.setDuration(reflect.GetDuration());
                    
                    //Dispaly Get Ready... Message
                    reflect.DisplayGetReady();
                    
                    //Spin
                    reflect.PauseNSpinner(6);

                    //Get and display random prompt
                    string prompt = reflect.GetRandomPrompt();
                    reflect.DisplayPrompt(prompt);
                    
                    //Get and display prompt questions
                    string question = reflect.GetPromptQuestion();
                    reflect.DisplayPromptQuestions(question);
                    
                    //Display end message
                    reflect.DisplayEndMsg();
                    break;

                
                //Listing Activity
                case 3:
                    //Clear Console
                    Console.Clear();
                    //Declare breathing class
                    ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the experinces that have given you learning and light");
                    
                    //Display welcoming message
                    listing.DisplayStartingMsg();
                    
                    //Get and set the duration of the activity
                    listing.setDuration(listing.GetDuration());
                    
                    //Dispaly Get Ready... Message
                    listing.DisplayGetReady();
                    
                    //Spin
                    listing.PauseNSpinner(6);
                    
                    //Get and display a random prompt
                    string prompt1 = listing.GetRandomPrompt();
                    listing.DisplayPrompt(prompt1);

                    //Get prompt answer from user
                    listing.GetPromptAnswer();

                    //Display end message
                    listing.DisplayEndMsg();
                    break;
                
                
                //Quit
                case 4:
                    Console.WriteLine("GoodBye! Have a great day!");
                    quit = true;
                    break;

                
                //Invaild answer
                default:
                    Console.Write("Invalid Answer! Try Again");
                    Console.WriteLine();
                    break;
            }
        }
    }
}