using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //www.plantuml.com/plantuml/png/pLR1RXCn4BtxArRY4fJc1r25MgKKa8YeqgeS44B6EqciUhqhsniK0V-EFKuc4wSHaHgWfwoVnpDlthD7kV11kj0tHYWZlQzkughw8KPV6sdxcLIXT-1ULJuuRUSHxgHwa7DWI6WDE6dL5XCltaAOiFE3bxINjcvoZWAzM-VXk1XUrdMYbB1bgsinZ97lxQnbGSChxJiZLpjnluJ0Liv_ZaRL5BpseNKC6ilOYKwOo9rJ47RlS97OyDxRx-0-oH0yRt_L0UExoJB8IDN81t1drNgrLe_ML2P2OXD3LIWirQ05wHrR5T-aXq6kGSbPHBPYIbLA8wXKwSMgEvaDWeJDmYzqjq6AhRk5Q_lvubsaZnlC7Jp671930lwps3mhpuPfsFcdY4WgS8NuTGtGTECMPZEjDDZ0Z6Cd_e5AX1I4Jg0UNilTh4otKuXB8m4bLRWgHu2J0UhxreHY1XxKdv8Uf_w-aiI36u8qbaZZCSt3MlEZfaDc-DXucB9c-TRVSo9peO4mwKtGCGpSE59kj2e3BatVQDitRmoeu5gh5RcvTnQdnlw1utmXtm-O9VRTEkpBWQV0I_3SF2ScK-nXFKtlBDM-AFW2sWuYftWycSqkkm5PtqPASRM3sdbO4F0if2PyfnL2MIE4vJPEx14-cO-SG_6SFcoPb3l8vyIJxXQaKmiqsUFdlJGzi18vO72bLT2jbMvrdhVEgfJnTQLZYt5ABzEnT0MljILEwHSvnO-I5rsvYRHHmcjj05dCueUL3V3xf2tupVhpbuX89CD24elqJwM0Kas28hbjhJyqH9SWLs9lYsbu0RRk6_CR
        
        var items = new Dictionary<string, Part>();
        
        

        bool quit = false;

        while (quit != true) {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please pick a menu option:");
            Console.WriteLine(" 1. Add Item");
            Console.WriteLine(" 2. Remove Item");
            Console.WriteLine(" 3. List Items");
            Console.WriteLine(" 4. Search Item");
            Console.WriteLine(" 5. Load File");
            Console.WriteLine(" 6. Quit");

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
                            Console.WriteLine("What is the resitance of the resistor");
                            string chipResistance = Console.ReadLine();

                            items.Add(chipResistance, new ChipResistor(chipResistance));
                            break;

                        case 2: 
                            Console.WriteLine("What is the resitance of the resistor");
                            string throughHoleResistance = Console.ReadLine();

                            items.Add(throughHoleResistance, new ThroughHoleResistor(throughHoleResistance));
                            break;

                        case 3: 
                            Console.WriteLine("What is the resitance of the resistor");
                            string multilayerCapacitence = Console.ReadLine();

                            items.Add(multilayerCapacitence, new MultilayerCeramic(multilayerCapacitence));
                            break;

                        case 4: 
                            Console.WriteLine("What is the resitance of the resistor");
                            string aluminumCapacitence = Console.ReadLine();

                            items.Add(aluminumCapacitence, new AluminumElectronic(aluminumCapacitence));
                            break;


                        default:
                            Console.WriteLine("Invailid Answer! Try Again");
                            break;
                    }
                    break;
                
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                
                case 4:
                    Console.WriteLine("Case");
                    break;
                
                case 5:
                    Console.WriteLine("Case");
                    break;

                case 6:
                    Console.WriteLine("Case");
                    break;
                
                default:
                    Console.WriteLine("Invailid Answer! Try Agian");
                    break;
            }
        }  
    }
}