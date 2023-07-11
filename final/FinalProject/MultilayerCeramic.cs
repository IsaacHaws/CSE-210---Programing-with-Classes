using System;


public class MultilayerCeramic : Capacitor {


    public MultilayerCeramic() {
       
    }

    public MultilayerCeramic(string maker, string package, string tolerance, string capacitance, string ratedVoltage, string tempCoefficient, int quantity): base(maker, package, tolerance, capacitance, ratedVoltage, tempCoefficient, quantity) {

    }
    
    
    public override void AddPart() {
        
    }

    public override string GetInfo() {
        return $"MultilayerCeramic,{GetManufacturer()},{GetPackage()},{GetTolerance()},{GetCapacitance()},{GetRatedVoltage()},{GetTempCoefficient()},{GetQuantity()}";
    }

    public override void DisplayPart(int num) {
        Console.WriteLine($"[{num}]. MultilayerCeramic\n" + 
        $"  Manufacturer: {GetManufacturer()}\n" +  
        $"  Package: {GetPackage()}\n" + 
        $"  Tolerance: {GetTolerance()}\n" +
        $"  Capacitance: {GetCapacitance()}\n" +
        $"  Rated Voltage: {GetRatedVoltage()}\n" +
        $"  Temperature Coefficient: {GetTempCoefficient()}\n" +
        $"  Quantity: {GetQuantity()}\n");
    }
}