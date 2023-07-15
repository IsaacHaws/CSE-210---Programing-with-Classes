using System;


public class Search {
    //private int _searchNum;
    private string _searchValue;
    private int _partIndex;
    

    public Search(List<Part> items) {
        Console.WriteLine();
        Console.WriteLine(
        "1. ChipResistor\n" + 
        "2. ThroughHoleResistor\n" +
        "3. MultilayerCeramic\n" + 
        "4. AluminumElectronic");
        Console.Write("What part would you like to search for? ");

        switch (int.Parse(Console.ReadLine()))
        {   
            //Chip Resistor
            case 1: 
                Console.WriteLine(
                "\n1. Manufacturer\n" + 
                "2. Package\n" + 
                "3. Tolerance\n" + 
                "4. Resistance\n" + 
                "5. Power in Watts");
                Console.Write("What value of the part would you like to search for: ");
                _partIndex = int.Parse(Console.ReadLine());

                Console.Write("\nPlease enter the value you want to search for: ");
                _searchValue = Console.ReadLine();

                FindPart(items, _partIndex, _searchValue);
                break;

            case 2: 
                //Through Hole Resistor
                Console.WriteLine(
                "\n1. Manufacturer\n" + 
                "2. Package\n" + 
                "3. Tolerance\n" + 
                "4. Resistance\n" + 
                "5. Power in Watts\n" + 
                "6. Temperature Coefficient");
                Console.Write("What value of the part would you like to search for: ");
                _partIndex = int.Parse(Console.ReadLine());

                Console.Write("\nPlease enter the value you want to search for: ");
                _searchValue = Console.ReadLine();

                FindPart(items, _partIndex, _searchValue);
                break;

            case 3:
                //Multilayer Ceramic Capacitor 
                Console.WriteLine(
                "\n1. Manufacturer\n" + 
                "2. Package\n" + 
                "3. Tolerance\n" +
                "4. Capacitance\n" + 
                "5. RatedVoltage\n" +
                "6. Temperature Coefficient");
                Console.Write("What value of the part would you like to search for: ");
                _partIndex = int.Parse(Console.ReadLine());
                
                Console.Write("\nPlease enter the value you want to search for: ");
                _searchValue = Console.ReadLine();

                FindPart(items, _partIndex, _searchValue);
                break;

            case 4: 
                //Aluminum Electronic Capacitor
                Console.WriteLine(
                "\n1. Manufacturer\n" + 
                "2. Package\n" + 
                "3. Tolerance\n" +
                "4. Capacitance\n" + 
                "5. RatedVoltage\n" +
                "6. Temperature Coefficient\n" +
                "7. Operating Temperature\n" +
                "8. Lead Spacing");
                Console.Write("What value of the part would you like to search for: ");
                _partIndex = int.Parse(Console.ReadLine());

                Console.Write("\nPlease enter the value you want to search for: ");
                _searchValue = Console.ReadLine();

                FindPart(items, _partIndex, _searchValue);
                break;
            
            //Default
            default:
                Console.WriteLine("Invaild Answer!");
                break;
        } 
    }


    public void FindPart(List<Part> items, int index, string value) {
        List<Part> searchedItems = new List<Part>();
        
        int l = 0;
        Console.WriteLine("Here are the parts: ");
        foreach (var item in items) {
           string itemInfo = item.GetInfo();
           string[] splitInfo = itemInfo.Split(",");

           if (splitInfo[index] == _searchValue) {
                searchedItems.Add(item);
                PrintItem(searchedItems, l);
                l++;
           }
        }
        if(l == 0) {
            Console.WriteLine("There were no parts found with that value\n");
        }
    }

    public void PrintItem(List<Part> searchedItems, int index) {
        searchedItems[index].DisplayPart(index + 1);
    }
}