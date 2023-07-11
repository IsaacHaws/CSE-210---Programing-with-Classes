using System;


public class AluminumElectronic : Capacitor {
    private string _operatingTemp;
    private string _leadSpacing;


    public AluminumElectronic() {
        Console.Write("What is the operating temperture value of the capacitor? ");
        _operatingTemp = Console.ReadLine();
    }

    public AluminumElectronic(string maker, string package, string tolerance, string capacitance, string ratedVoltage, string tempCoefficient, string operatingTemp, string leadSpacing, int quantity): base(maker, package, tolerance, capacitance, ratedVoltage, tempCoefficient, quantity) {
        _operatingTemp = operatingTemp;
        _leadSpacing = leadSpacing;
    }

    public string GetOperatingTemp() {
        return _operatingTemp;
    }

    public string GetLeadSpacing() {
        return _leadSpacing;
    }



    public override void AddPart() {
        
    }

    public override string GetInfo() {
        return $"AluminumElectronic,{GetManufacturer()},{GetPackage()},{GetTolerance()},{GetCapacitance()},{GetRatedVoltage()},{GetTempCoefficient()},{GetOperatingTemp()},{GetLeadSpacing()},{GetQuantity()}";
    }

    public override void DisplayPart(int num) {
        Console.WriteLine($"[{num}]. AluminumElectronic\n" + 
        $"  Manufacturer: {GetManufacturer()}\n" +  
        $"  Package: {GetPackage()}\n" + 
        $"  Tolerance: {GetTolerance()}\n" +
        $"  Capacitance: {GetCapacitance()}\n" +
        $"  Rated Voltage: {GetRatedVoltage()}\n" +
        $"  Temperature Coefficient: {GetTempCoefficient()}\n" +
        $"  Operating Temperature: {GetOperatingTemp()}\n" +
        $"  Lead Spacing: {GetLeadSpacing()}\n" +
        $"  Quantity: {GetQuantity()}\n");
    }
}