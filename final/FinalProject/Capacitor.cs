using System;


public class Capacitor : Part {
    private string _capacitance;
    private string _ratedVoltage;
    private string _tempCoefficient;

    
    public Capacitor() {
        Console.Write("What is the capacitance of the capacitor? ");
        _capacitance = Console.ReadLine();

        Console.Write("What is the rated voltage of the capacitor? ");
        _capacitance = Console.ReadLine();

        Console.Write("What is the temperture coefficient value of the capacitor? ");
        _tempCoefficient = Console.ReadLine();
    }
    
    public Capacitor(string maker, string package, string tolerance, string capacitance, string ratedVoltage, string tempCoefficient, int quantity): base(maker, package, tolerance, quantity) {
        _capacitance = capacitance;
        _ratedVoltage = ratedVoltage;
        _tempCoefficient = tempCoefficient;
    }


    
    protected string GetCapacitance() {
        return _capacitance;
    }

    protected string GetRatedVoltage() {
        return _ratedVoltage;
    }

    protected string GetTempCoefficient() {
        return _tempCoefficient;
    }



    public override void AddPart() {
        
    }

    public override string GetInfo() {
        return $"Capacitor,{GetManufacturer()},{GetPackage()},{GetTolerance()},{GetCapacitance()},{GetRatedVoltage()},{GetTempCoefficient()},{GetQuantity()}";
    }

    public override void DisplayPart(int num) {
        Console.WriteLine($"[{num}]. Capacitor\n" + 
        $"  Manufacturer: {GetManufacturer()}\n" +  
        $"  Package: {GetPackage()}\n" + 
        $"  Tolerance: {GetTolerance()}\n" +
        $"  Capacitance: {GetCapacitance()}\n" +
        $"  Rated Voltage: {GetRatedVoltage()}\n" +
        $"  Temperature Coefficient: {GetTempCoefficient()}\n" +
        $"  Quantity: {GetQuantity()}\n");
    }
}