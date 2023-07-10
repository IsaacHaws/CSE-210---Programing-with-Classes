using System;


public class ChipResistor : Resistor {


    public ChipResistor() {
        
    }

    public ChipResistor(string maker, string package, string tolerance, string resistance, string powerWatts, int quantity): base(maker, package, tolerance, resistance, powerWatts, quantity) {

    }

    public override void AddPart() {
        
    }

    public override string GetInfo() {
        return $"{GetManufacturer()},{GetPackage()},{GetTolerance()},{GetResistance()},{GetPowerWatts()},{GetQuantity()}";
    }

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