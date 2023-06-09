using System;

class Program
{
    static void Main(string[] args)
    {
        //www.plantuml.com/plantuml/png/hLHDgnCn5DtdLmJSl67QF_0eZ_TijHIaY5su495qSgt1J38aTugY_dVptJXC5vPsqKdElRdtd9EFPulCuDXBqabcBTrg9kalilnoSeCzw-6HMZH2dHAq0TiPCQ3GQX9vhuL2-qZTFo6hrLehYsE7sZmzaTQNVOZfLBcg2vec_59luPVI8PHf27cr1Tmc4WzDRfRXciWqMiXK0T9-W4uR7eWqaMMx4NQGx6V6pbfmqkxiMlU310JkmQFMalmXxXUiMVrUBkb1-0G_hy0t24OnEK7Ntw3xBeN5W1CIRSuLijbTxXZx5V_CpGOkGY5Q2ZV4rG0iqWx84BA-UxWJTHKJlB2937lJGRW3jqYjx4Hn_QZLQFTZ7shc-KklHuK1edVP1pz6qKCQXYODfV60lquKZc2ojWWN9Xc-QWEJ_sN3WPqXgFyg9AZgWi-8zRbPh4_tLp7TpBTfzJzNxACH23wIoLHztsd6P_iwI0e5Diy_VNQ8JzWf3Z-ghChXQIXwdL0tdD7Y-zTQr4NBp0jp_NN9Bqi-8UqBBtlYlqxoCoW-zl8l

        int points = 0;

        bool quit = false;

        List<Goal> goals = new List<Goal>();

        while (quit != true) {
            DisplayMenu();

            //Get menu input
            Console.Write("Select a choice from the menu: ");
            int menuAnswer = int.Parse(Console.ReadLine());
            
            //Switch statment to handle menu input
            switch (menuAnswer)
            {
                case 1: 
                    //Print goal menu and get user input
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    int goaltype = int.Parse(Console.ReadLine());

                    if (goaltype == 1) {
                        //Add SimpleGoal to goals list
                        goals.Add(new SimpleGoal(false));
                    }

                    else if (goaltype == 2) {
                        //Add EternalGoal to goals list  
                        goals.Add(new EternalGoal());
                    }

                    else if (goaltype == 3) {
                        //Add CheckListGoal to goals list 
                        goals.Add(new ChecklistGoal());
                    }
                    break;
                
                //List goals
                case 2:   
                    int i = 1; 
                    Console.WriteLine("The goals are:");
                    foreach (Goal goal in goals) {
                        goal.DisplayGoal(i);
                        i++;
                    }
                    Console.WriteLine();
                    break;


                //Save goals
                case 3: 
                    ManageFile save = new ManageFile(goals, points, "save");
                    break;
                    
                
                //Load goals
                case 4: 
                    ManageFile load = new ManageFile(goals, points, "load");
                    points = load.GetTotalPoints();
                    break;

                
                //Record goals
                case 5: 
                    //Print goals
                    Console.WriteLine("The goals are: ");
                    int l = 1;
                    foreach (Goal goal in goals) {
                        goal.DisplayPartGoal(l);
                        l++;
                    }
                    
                    //Ask which goal is to be recorded
                    Console.Write("Which goal did you accomplish? ");
                    int goalIndex = int.Parse(Console.ReadLine());

                    //Record selected goal and get points 
                    int addedPoints = goals[goalIndex - 1].RecordGoal();
                    points += addedPoints;
                    
                    //Print new point amount
                    Console.WriteLine($"You now have {points} points.\n");
                    break;

                
                //End program
                case 6: 
                    Console.WriteLine();
                    Console.WriteLine("GoodBye");
                    
                    quit = true;
                    break;

                  
                default:
                    Console.WriteLine("Invalid Answer! \nNumber must be between 1 and 6!");
                    break;
            }
        }
    
        
        //Function to print menu
        void DisplayMenu() {
            Console.WriteLine($"You have {points} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
        }
    }
}