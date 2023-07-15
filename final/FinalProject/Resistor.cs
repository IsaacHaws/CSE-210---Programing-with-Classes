using System;


public class Resistor : Part {
    private string _resistance;
    private string _powerWatts;
    
    //Constructor to ask the user for class variable values
    public Resistor() {
        Console.Write("What is the resistance of the resistor? ");
        _resistance = Console.ReadLine();

        Console.Write("What is the power rating in Watts? ");
        _powerWatts = Console.ReadLine();
    }

    //Constructor to get class variable values through parameters
    public Resistor(string maker, string package, string tolerance, string resistance, string powerWatts, int quantity): base(maker, package, tolerance, quantity) {
        _resistance = resistance;
        _powerWatts = powerWatts;
    }


    //Return the value of "_resistance"
    protected string GetResistance() {
        return _resistance;
    }

    //Return the value of "_powerWatts"
    protected string GetPowerWatts() {
        return _powerWatts;
    }    


    public override void AddPart() {
        
    }


    //Return the class info in CSV form
    public override string GetInfo() {
        return $"Resistor,{GetManufacturer()},{GetPackage()},{GetTolerance()},{GetResistance()},{GetPowerWatts()},{GetQuantity()}";
    }

    //Display part info
    public override void DisplayPart(int num) {
        Console.WriteLine($"[{num}]. Resistor\n" + 
        $"  Manufacturer: {GetManufacturer()}\n" +  
        $"  Package: {GetPackage()}\n" + 
        $"  Tolerance: {GetTolerance()}\n" +
        $"  Resistance: {GetResistance()}\n" +
        $"  Power: {GetPowerWatts()}\n" +
        $"  Quantity: {GetQuantity()}\n");
    }
}