using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //www.plantuml.com/plantuml/png/pLRRRXCn47ttLwp4Ir2Q7wWgr2gbW4H4bLRb0I4qU2U9LQ-zihr54V3l-D9C9WuNf8RIfwpFNERCcR6LKn_0XQ7JGchmlhcCf-Qhc7pgm0mBa65mw8uR7vmoomZt86zXYGm9LgC38xUOUFOAmup5ZvwJBPakIuuAlTxaORWOdxLjefImEwjQCOwURyp2CgVnkVAzXlMEttSXSYidtoQJPevU-M0TWwOGEr494wLpSihTktn8R7ZlzWkwzn22v-slUsHyDrb61Mawk4LtrDoVxjMZCvM9aDZuK1LoIpNeG7h7LiLdy3WgDIWvyoYZc5ELUX1Kgfx5kZ_O60G9MuHVgNw3LARhbRF3SlKwqiy6FfqIHXCIOmB-izWyAy-Mqx3uXuX8Ad25-Be6xFgfnSL2IOKciC6nY4TGYP2Aq07KoskvcvNfTWXnwKd8aiuXO7jZTTXzxMHnuY_3R_Mdf7-fFgjQoyidGZH-gdd8cXVDU1_LBPzI4cRvbqANWdJVPuCEAhgXcwA3JidQuKmFdJ93zrAZ3CuQ9MbOUx7vKTWFU7pPZt-nwRm4pyrpvcIItPk7wLsasXSbBxZjCNAAuMdOR9SrGdiLASNJ3cgMOKN0av2Qy9rM26MD45RQEE2Cw9wzunogw_HsowIsP3u7ViYk49nSvI7x_7a3Ua1MeZYCpfKCoXfmwvDYEcfInXUDYYt6H_WkXQKLl526EANVp2b-rBnevMPWeeGNIcDciOWV1Zha-wGC-itvmyU8G2R3N1ABz4UaWb9DWYAvRQq_D4HBK2gnkyKqF4NJ3ft-0G00
        
        var resistors = new Dictionary<string, Resistor>();
        var capacitor = new Dictionary<string, Capacitor>();

        resistors.Add("ChipResistor", new ChipResistor());

        bool quit = false;

        while (quit != true) {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please pick a menu option:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Search Item");
            Console.WriteLine("4. Load File");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do");
            int menuAnswer = int.Parse(Console.ReadLine());

            switch (menuAnswer)
            {
                case 1:
                    Console.WriteLine("Case 1");
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
                
                default:
                    Console.WriteLine("Invailid Answer! Try Agian");
                    break;
            }
        }  
    }
}