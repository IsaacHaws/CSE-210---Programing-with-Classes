using System;


public class ChipResistor : Resistor {


    public ChipResistor() {
        
    }

    //Constructor to get class variable values through parameters
    public ChipResistor(string maker, string package, string tolerance, string resistance, string powerWatts, int quantity): base(maker, package, tolerance, resistance, powerWatts, quantity) {

    }

    public override void AddPart() {
        
    }

    //Return the class info in CSV form
    public override string GetInfo() {
        return $"ChipResistor,{GetManufacturer()},{GetPackage()},{GetTolerance()},{GetResistance()},{GetPowerWatts()},{GetQuantity()}";
    }

    //Display part info
    public override void DisplayPart(int num) {
        Console.WriteLine($"[{num}]. ChipResistor\n" + 
        $"  Manufacturer: {GetManufacturer()}\n" +  
        $"  Package: {GetPackage()}\n" + 
        $"  Tolerance: {GetTolerance()}\n" +
        $"  Resistance: {GetResistance()}\n" +
        $"  Power: {GetPowerWatts()}\n" +
        $"  Quantity: {GetQuantity()}\n");
    }
}