using System;


public class Search {
    private string _searchValue;
    private int _searchNum;


    public Search(List<Part> items) {
        
        Console.WriteLine("What part would you like to search for?");
        Console.WriteLine(
        "1. ChipResistor" + 
        "2. ThroughHoleResistor" +
        "3. MultilayerCeramic" + 
        "4. AluminumElectronic");
        _searchNum = int.Parse(Console.ReadLine());

        switch (_searchNum)
        {
            case 1: 
                Console.WriteLine("What value of the part would you like to search for");
                Console.WriteLine("1. Manufacturer");
                _searchValue = Console.ReadLine();
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


    public void FindPart(int index, string value) {

    }

    public void PrintFindings() {

    }

    public string GetPartInfo() {
        return "";
    }
}