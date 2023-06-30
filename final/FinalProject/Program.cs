using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //www.plantuml.com/plantuml/png/jLLHQzim47xNhp3q9I7j7oXbjBJhDbXPIKltC4RHP2KHbIKZoHbXwt_VIOhF5yKROSlUh4ztdx_xxiw-z86xq3MQ2Sszh-xXLFrWPyyDDzs2Yz0vwSuh7vmoIu1RBbxuKX8aM2qTDsB0s2ooJARzGuQhXhz8TrfjJriYF2CDf9sya-6El7yoHUvuTPzJ2_In9o0ucrtLTT80sDggciqWyeDPM18qkr6-rNop4_VAMBBYukVPMJMNNlbW7O6kEHIW8iQoSnW4xfqyktI8QgXtzhjqdta8djgtQQbpFKjlsa0qBMuFjnGGLj8DKOCgXA8cC89zurvEyZi6yh9HSwGisuJ4PQU0_bXDOcXxRijAjJrIN3skdEsMg_SWFrtGtj4qw1-R8J3UYlCgMKEGVwa2POn8JBiOPDDUMxbOAA6a2SIvCkDmkQaHkxn4w36gmHL96o7IgLm9nuEidwmEz9lofu8pAIcJy4xn_czMfEIZQvDahfDCaeiYGnG91XoqBrdXsCBCYHdqwlzrAcl15RdhT50G9jqrI6wKA0EkTDSeqpLljHJ1MQC4TdilD-tHVaBPDpAV21rfdqRafdMoBIWCa1zT9LEd9QyVG0ASTb2p32i4ncewRDReh8z_eqjdVZjhYE-KWYWf1B5SnlHyzADUQ2EYg9YaGWnJk1teJrH3CRSV1oNbJT9pv4_EW-HEh5AJVNfyuhgZlzSSCBbH8YXhkDjSvAlJAZA-gHIKEFm7rv2THl5McNrf09JoNd4Rk04dRvMMISm27Wnl91qhPQJlpr--0iAJ9X8InSH_PG75To84uePt7LfNVXFPCMBbfJHrr-XV
        
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