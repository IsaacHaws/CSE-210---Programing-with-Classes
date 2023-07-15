using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //www.plantuml.com/plantuml/png/pLJHRjGm47ptLqJY9T6rFr1Lg5MXWDIAggtA0qB8E7izguuJx4tH2VhlsF5bRyzt845pWhViP3qxcOdtnADqs3T6A2EzBwv2LNmNXvyRQVkvLDWxS4U5HwVjVO0xgHxaFJ04MmDEMiMnhxsqg75vL6YBGimYQrcD3wcjQEG3k8DYLQs8gIRQWyXHZ8o1vCKRm4kchgneSdnrbOWoz7QaOxYOdTPrL1InnrRNOXOwtzbvovfchxJlZ5nkz3q9CHXr_EFmiBW6hpssZa5difDAHqmaNwbfyDODHUPPrtu3zq4YUYPmF5PMlFXJ0yKAMi-bhlNKpEUZGdoH7ieqXDWvRPR9DR7dYT2CgSmNP6UoUw6x4SbUtIvSszyltWRLr35caevHBcB6WR8YuFzodTDn7k9uZhNaJUOR_Re8JNVMmdokbGQBBCxi17d8yFrQIL2cSHyMfvsoEOUPEq42j4EIxofLsSvm4g6-QmtobVoxa8YqhAXwJY1C5hKDeXwJg1sPu5zbadkVfE_QDjVC4_vgVu4bBRHoBdk3EhI1EmCd6wtoXbFJDzhspMi32brhjQBGjyuEUsaBBQkTwCGfaetJtIm-AHknnKsynIJtQTlruMAr7JY9uNpyETWTCY3hco0sLFmloKbI53dyBx8WXeqledRsFNkFZL_KzrnDTXylrfecNfut89rQ307xuV5EcXxOYDHGNcYFnv7ZPQ4H6azsFSR-6EsvjjjY0f0BUg8hB6qmvbmR6CRFmuEL3V1VIrlmO_tnKq2aGjrQrXB5t2uxoA0uaw0WRZthrr-Ik2kobTjr0hRk6_CJ
        
        //List of Parts
        List<Part> items = new List<Part>();
        
        //Bool for while loop
        bool quit = false;
        
        //Clear Console and print welcome message
        Console.Clear();
        Console.WriteLine("Welcome!");
        
        //Loop until user sets quit to "True"
        while (quit != true) {
            //Display Menu
            Console.WriteLine("Please pick a menu option:");
            Console.WriteLine(" 1. Add Item");
            Console.WriteLine(" 2. Remove Item");
            Console.WriteLine(" 3. Edit Quantity");
            Console.WriteLine(" 4. List Items");
            Console.WriteLine(" 5. Search Item");
            Console.WriteLine(" 6. Load File");
            Console.WriteLine(" 7. Save File");
            Console.WriteLine(" 8. Quit");
            Console.Write("What would you like to do? ");

            //Get user answer for switch stament 
            switch (int.Parse(Console.ReadLine()))
            {   
                //Add Part
                case 1:
                    //Ask what part they would like to add
                    Console.WriteLine(" 1. Chip Resistor");
                    Console.WriteLine(" 2. Through Hole Resistor");
                    Console.WriteLine(" 3. Multilayer Ceramic Capacitor");
                    Console.WriteLine(" 4. Aluminum Electronic Capacitor");
                    Console.Write("What type of item would you like to add: ");

                    //Get user answer
                    switch (int.Parse(Console.ReadLine()))
                    {   
                        //Add ChipResistor
                        case 1:
                            items.Add(new ChipResistor());
                            break;

                        //Add ThroughHoleResistor
                        case 2: 
                            items.Add(new ThroughHoleResistor());
                            break;
                        
                        //Add MultilayerCeramic Capacitor
                        case 3: 
                            items.Add(new MultilayerCeramic());
                            break;

                        //Add AluminumElectronic Capacitor
                        case 4: 
                            items.Add(new AluminumElectronic());
                            break;

                        //Default answer
                        default:
                            Console.WriteLine("Invailid Answer! Try Again");
                            break;
                    }
                    break;
                
                //Remove part
                case 2:
                    int i = 1;
                    //Loop through list and print each part
                    foreach (var item in items) {
                        //Display part using class method
                        item.DisplayPart(i);
                        i++;
                    }
                    
                    //Ask user what item they would like to remove
                    Console.Write("\nWhich item would you like to remove? ");

                    //Remove part from list using built in method
                    items.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                    break;

                //Edit Quantity
                case 3:
                    int amount;
                    //Ask user if they want to add or subtract
                    Console.WriteLine("Would you like to add or subtract the quantity? ");
                    Console.Write("1. Add, " + "2. Subtract:  ");
                    int editAnswer = int.Parse(Console.ReadLine());

                    int j = 1;
                    //Loop through list and print each part
                    foreach (var item in items) {
                        //Display part using class method
                        item.DisplayPart(j);
                        j++;
                    }
                    
                    //Ask user for which part they want to edit 
                    Console.Write("What part would you like to edit? ");
                    int editIndex = int.Parse(Console.ReadLine()) - 1;

                    //Add quantity
                    if(editAnswer == 1) {
                        //Get amount to add
                        Console.Write("\nHow many would you like to add to the part? ");
                        amount = int.Parse(Console.ReadLine());
                        
                        //Add using class method
                        items[editIndex].EditQuantity(amount, "Add");
                    }

                    //Subtract quantity
                    else if(editAnswer == 2) {
                        //Get amount to subtract
                        Console.Write("\nHow many would you like to subtract from the part? ");
                        amount = int.Parse(Console.ReadLine());
                        
                        //Subtract using class method
                        items[editIndex].EditQuantity(amount, "Subtract");
                    }
                    Console.WriteLine();
                    break;
                
                //Print list
                case 4:
                    int l = 1;
                    Console.WriteLine("\nThe parts are:");
                    //Print each item using class method
                    foreach (var item in items) {
                        item.DisplayPart(l);
                        l++;
                    }
                    break;
                
                //Search for item value
                case 5:
                    Search search = new Search(items);
                    break;
                
                //Load from selected file
                case 6:
                    ManageFile load = new ManageFile(items, "load");
                    break;

                //Save to selected file
                case 7:
                    ManageFile save = new ManageFile(items, "save");
                    break;

                //Quit
                case 8: 
                    Console.WriteLine("Goodbye");
                    //Set quit to "true"
                    quit = true;
                    break;
                
                //Default
                default:
                    Console.WriteLine("Invailid Answer! Try Agian");
                    break;
            }
        }  
    }
}