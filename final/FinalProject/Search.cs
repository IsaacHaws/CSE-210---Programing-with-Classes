using System;


public class Search {
    private int _searchNum;
    private string _searchValue;
    private int _partIndex;
    

    public Search(List<Part> items) {
        Console.WriteLine("\nWhat part would you like to search for?");
        Console.WriteLine(
        "1. ChipResistor\n" + 
        "2. ThroughHoleResistor\n" +
        "3. MultilayerCeramic\n" + 
        "4. AluminumElectronic\n");
        _searchNum = int.Parse(Console.ReadLine());

        switch (_searchNum)
        {
            case 1: 
                Console.WriteLine("What value of the part would you like to search for: ");
                Console.WriteLine("1. Manufacturer");
                Console.WriteLine("2. Package");
                Console.WriteLine("3. Tolerance");
                Console.WriteLine("4. Resistance");
                Console.WriteLine("5. Power in Watts");
                _partIndex = int.Parse(Console.ReadLine());

                Console.Write("Please enter the value you want to search for: ");
                _searchValue = Console.ReadLine();

                FindPart(items, _partIndex, _searchValue);
                break;

            case 2: 
                break;

            case 3: 
                break;

            case 4: 
                break;
            
            default:
                break;
        }
        
        
        
    }


    public void FindPart(List<Part> items, int index, string value) {
        List<Part> searchedItems = new List<Part>();
        
        int l = 0;
        foreach (var item in items) {
           string itemInfo = item.GetInfo();
           string[] splitInfo = itemInfo.Split(",");

           if (splitInfo[index] == _searchValue) {
                searchedItems.Add(item);
                PrintItem(searchedItems, l);
                l++;
           }
        }
    }

    public void PrintItem(List<Part> searchedItems, int index) {
        searchedItems[index].DisplayPart(1);
    }

    // public string GetPartInfo() {
    //     return "";
    // }
}