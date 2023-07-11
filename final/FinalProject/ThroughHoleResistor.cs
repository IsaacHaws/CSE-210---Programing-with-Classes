using System;


public class ThroughHoleResistor : Resistor {
    private string _tempCoefficient;


    public ThroughHoleResistor() {
        Console.Write("What is the temperture coefficient value of the resistor? ");
        _tempCoefficient = Console.ReadLine();
    }
    
    public ThroughHoleResistor(string maker, string package, string tolerance, string resistance, string powerWatts, string tempCoefficient, int quantity): base(maker, package, tolerance, resistance, powerWatts, quantity) {
        _tempCoefficient = tempCoefficient;
    }


    public string GetTempCoefficient() {
        return _tempCoefficient;
    }


    public override void AddPart() {
        
    }

    public override string GetInfo() {
        return $"ThroughHoleResistor,{GetManufacturer()},{GetPackage()},{GetTolerance()},{GetResistance()},{GetPowerWatts()},{GetTempCoefficient()},{GetQuantity()}";
    }

    public override void DisplayPart(int num) {
        Console.WriteLine($"[{num}]. ThroughHoleResistor\n" + 
        $"  Manufacturer: {GetManufacturer()}\n" +  
        $"  Package: {GetPackage()}\n" + 
        $"  Tolerance: {GetTolerance()}\n" +
        $"  Resistance: {GetResistance()}\n" +
        $"  Power: {GetPowerWatts()}\n" +
        $"  Temperature Coefficient: {GetTempCoefficient()}\n" +
        $"  Quantity: {GetQuantity()}\n");
    }
}