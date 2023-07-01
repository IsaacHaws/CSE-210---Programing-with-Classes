using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //www.plantuml.com/plantuml/png/jLJ1QXin4BthAmIvs3Z-0HDAWjEqXOO6nwI7KeAg7TiYMkrMqhgODlzUQUKTZxMkCSIzhPvcdjwycTbhvuNrJQcPrC8v_X1E_3SRFvV2D0iXVMF1JhZpLfbbW6iXNyGI2E8h3LOOIR6VZJ1U-Ss4A-CP6qNMmR3xI66y52zWB_dsj2N6Cz9UHWxUCGQIYm_WxucwmH1VZbSFYIX3vnqTmTdefYYYeeYjArMmKOZyP1OL2HhTAbThiTcBUsMiDUhgptZCP-2KyvKbq5I4SbJ4MF8LWuAt5y-sFMIUrTKli5-5zuu8xD8wptQPm_xjwOwo7jqk2sLanayu-o4S3D8Zo4vfioRDa3rl4Rvnhcumz3Vvlr9rXsHNyvMjckNgOr3TNM2JKXesYeqGEDo22MyT8SXRga0P1oIsA-cXhASLB1PAAZ2UE9Tbd2utxSO-Bn5wXcfm5zBeotJAPjyA3yLJfJtzjHmh64cxCWdlaDw_wMU3zuITB4yKlOwYAHDAzb5ov_dfIvEK7zgQ6J69Nls_3YOjk3htZVOgX86TWXMbadd0ZMvAPPholGRfRMMKn2devRRxrK_8-add5g5pxLd_zNRDgXgiy24_kagcKOCe7eE4SDf3pTAl43XMq_4Pn1qu_i-cplnhwX3VAmLHKWXYgOpXvE0_FjD6H54nhGgvcyBjG7-X6hAv_RnJqhk9UixyAte4OUMgRR9hFv-4Re0yaG86jqfwLHbXDrVfwf97ndTSUIWTUhQEsN4KxvJfIuj09kyLjq6OuEITqj2AMOGF8qgWOwKCkExyxNj0HAk9X4GnyqqD6HJVH2Y8sxrrQbtf9R9ZnCfhC4LJwhy0
        
        //var items = new Dictionary<string, Part>();
        
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