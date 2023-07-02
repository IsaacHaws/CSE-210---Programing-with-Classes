using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //www.plantuml.com/plantuml/png/pLJHRjGm47ptLqJY9T6rFr1Lg5MXWDIAggtA0qB8E7izguuJx4tH2VhlsF5bRyzt845pWhViP3qxcOdtnADqs3T6A2EzBwv2LNmNXvyRQVkvLDWxS4U5HwVjVO0xgHxaFJ04MmDEMiMnhxsqg75vL6YBGimYQrcD3wcjQEG3k8DYLQs8gIRQWyXHZ8o1vCKRm4kchgneSdnrbOWoz7QaOxYOdTPrL1InnrRNOXOwtzbvovfchxJlZ5nkz3q9CHXr_EFmiBW6hpssZa5difDAHqmaNwbfyDODHUPPrtu3zq4YUYPmF5PMlFXJ0yKAMi-bhlNKpEUZGdoH7ieqXDWvRPR9DR7dYT2CgSmNP6UoUw6x4SbUtIvSszyltWRLr35caevHBcB6WR8YuFzodTDn7k9uZhNaJUOR_Re8JNVMmdokbGQBBCxi17d8yFrQIL2cSHyMfvsoEOUPEq42j4EIxofLsSvm4g6-QmtobVoxa8YqhAXwJY1C5hKDeXwJg1sPu5zbadkVfE_QDjVC4_vgVu4bBRHoBdk3EhI1EmCd6wtoXbFJDzhspMi32brhjQBGjyuEUsaBBQkTwCGfaetJtIm-AHknnKsynIJtQTlruMAr7JY9uNpyETWTCY3hco0sLFmloKbI53dyBx8WXeqledRsFNkFZL_KzrnDTXylrfecNfut89rQ307xuV5EcXxOYDHGNcYFnv7ZPQ4H6azsFSR-6EsvjjjY0f0BUg8hB6qmvbmR6CRFmuEL3V1VIrlmO_tnKq2aGjrQrXB5t2uxoA0uaw0WRZthrr-Ik2kobTjr0hRk6_CJ
        
        List<Part> items = new List<Part>();
        
        bool quit = false;
        
        Console.Clear();
        Console.WriteLine("Welcome!");
        
        while (quit != true) {
            Console.WriteLine("Please pick a menu option:");
            Console.WriteLine(" 1. Add Item");
            Console.WriteLine(" 2. Remove Item");
            Console.WriteLine(" 3. List Items");
            Console.WriteLine(" 4. Search Item");
            Console.WriteLine(" 5. Load File");
            Console.WriteLine(" 6. Save and Quit");

            Console.Write("What would you like to do? ");
            int menuAnswer = int.Parse(Console.ReadLine());

            switch (menuAnswer)
            {
                case 1:
                    Console.WriteLine(" 1. Chip Resistor");
                    Console.WriteLine(" 2. Through Hole Resistor");
                    Console.WriteLine(" 3. Multilayer Ceramic Capacitor");
                    Console.WriteLine(" 4. Aluminum Electronic Capacitor");
                    Console.Write("What type of item would you like to add: ");
                    int itemType = int.Parse(Console.ReadLine());

                    switch (itemType)
                    {
                        case 1:
                            items.Add(new ChipResistor());
                            break;

                        case 2: 
                            items.Add(new ThroughHoleResistor());
                            break;

                        case 3: 
                            items.Add(new MultilayerCeramic());
                            break;

                        case 4: 
                            items.Add(new AluminumElectronic());
                            break;


                        default:
                            Console.WriteLine("Invailid Answer! Try Again");
                            break;
                    }
                    break;
                
                case 2:
                    int i = 0;
                    foreach (var item in items) {
                        Console.WriteLine($"[{i}]{item.DisplayPart()}");
                        i++;
                    }
                    
                    break;
                
                case 3:
                    foreach (var item in items) {
                        item.DisplayPart();
                    }
                    break;
                
                case 4:
                    Console.WriteLine("Case");
                    break;
                
                case 5:
                    Console.WriteLine("Case");
                    break;

                case 6:
                    Console.WriteLine("Goodbye");
                    quit = false;
                    break;
                
                default:
                    Console.WriteLine("Invailid Answer! Try Agian");
                    break;
            }
        }  
    }
}