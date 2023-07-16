using System;


public class Search {
    //private int _searchNum;
    private string _searchValue;
    private int _partIndex;
    
    //Constructor for searching the parts for certain values    
    public Search(List<Part> items) {
        //Ask what kind of part the user would like to look for
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
                //Ask user what type of value they would like to look for
                Console.WriteLine(
                "\n1. Manufacturer\n" + 
                "2. Package\n" + 
                "3. Tolerance\n" + 
                "4. Resistance\n" + 
                "5. Power in Watts");
                Console.Write("What value of the part would you like to search for: ");
                _partIndex = int.Parse(Console.ReadLine());

                //Ask user to enter the value to search for 
                Console.Write("\nPlease enter the value you want to search for: ");
                _searchValue = Console.ReadLine();

                //Find and print item using class methods
                FindPart(items, "ChipResistor", _partIndex, _searchValue);
                break;
            
            //Through Hole Resistor
            case 2: 
                //Ask user what type of value they would like to look for
                Console.WriteLine(
                "\n1. Manufacturer\n" + 
                "2. Package\n" + 
                "3. Tolerance\n" + 
                "4. Resistance\n" + 
                "5. Power in Watts\n" + 
                "6. Temperature Coefficient");
                Console.Write("What value of the part would you like to search for: ");
                _partIndex = int.Parse(Console.ReadLine());

                //Ask user to enter the value to search for
                Console.Write("\nPlease enter the value you want to search for: ");
                _searchValue = Console.ReadLine();

                //Find and print item using class methods
                FindPart(items, "ThroughHoleResistor", _partIndex, _searchValue);
                break;

            //Multilayer Ceramic Capacitor
            case 3:
                //Ask user what type of value they would like to look for
                Console.WriteLine(
                "\n1. Manufacturer\n" + 
                "2. Package\n" + 
                "3. Tolerance\n" +
                "4. Capacitance\n" + 
                "5. RatedVoltage\n" +
                "6. Temperature Coefficient");
                Console.Write("What value of the part would you like to search for: ");
                _partIndex = int.Parse(Console.ReadLine());
                
                //Ask user to enter the value to search for
                Console.Write("\nPlease enter the value you want to search for: ");
                _searchValue = Console.ReadLine();

                //Find and print item using class methods
                FindPart(items, "MultilayerCeramic", _partIndex, _searchValue);
                break;
            
            //Aluminum Electronic Capacitor
            case 4: 
                //Ask user what type of value they would like to look for
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

                //Ask user to enter the value to search for
                Console.Write("\nPlease enter the value you want to search for: ");
                _searchValue = Console.ReadLine();

                //Find and print item using class methods
                FindPart(items, "AluminumElectronic", _partIndex, _searchValue);
                break;
            
            //Default
            default:
                Console.WriteLine("Invaild Answer!");
                break;
        } 
    }


    public void FindPart(List<Part> items, string partType, int index, string value) {
        //List to put matched items in 
        List<Part> searchedItems = new List<Part>();
        
        int l = 0;
        Console.WriteLine("Here are the parts: ");
        
        //Compare each item at the certian index to the entered value
        foreach (var item in items) {
            //Get class method to get part info
            string itemInfo = item.GetInfo();

            //Split string at commas
            string[] splitInfo = itemInfo.Split(",");

            //If the part type from the list is the same as the user 
            //entered part type add part to tempoary list 
            if(splitInfo[0] == partType) {
                if (splitInfo[index] == _searchValue) {
                    searchedItems.Add(item);
                    
                    //Print item to console using class method
                    PrintItem(searchedItems, l);
                    l++;
                }
            } 
        }

        //If no items have been added to the list display message
        if(l == 0) {
            Console.WriteLine("There were no parts found with that value\n");
        }
    }

    //Display the part using class method
    public void PrintItem(List<Part> searchedItems, int index) {
        searchedItems[index].DisplayPart(index + 1);
    }
}