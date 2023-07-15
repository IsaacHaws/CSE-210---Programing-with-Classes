using System;


public class AluminumElectronic : Capacitor {
    private string _operatingTemp;
    private string _leadSpacing;

    //Constructor to ask the user for class variable values
    public AluminumElectronic() {
        Console.Write("What is the operating temperture value of the capacitor? ");
        _operatingTemp = Console.ReadLine();

        Console.Write("What is the distance between the leads? ");
        _leadSpacing = Console.ReadLine();
    }

    //Constructor to get class variable values through parameters
    public AluminumElectronic(string maker, string package, string tolerance, string capacitance, string ratedVoltage, string tempCoefficient, string operatingTemp, string leadSpacing, int quantity): base(maker, package, tolerance, capacitance, ratedVoltage, tempCoefficient, quantity) {
        _operatingTemp = operatingTemp;
        _leadSpacing = leadSpacing;
    }


    //Return the value of "_operatingTemp"
    public string GetOperatingTemp() {
        return _operatingTemp;
    }

    //Return the value of "_leadSpacing" 
    public string GetLeadSpacing() {
        return _leadSpacing;
    }




    //Return the class info in CSV form
    public override string GetInfo() {
        return $"AluminumElectronic,{GetManufacturer()},{GetPackage()},{GetTolerance()},{GetCapacitance()},{GetRatedVoltage()},{GetTempCoefficient()},{GetOperatingTemp()},{GetLeadSpacing()},{GetQuantity()}";
    }

    //Display part info
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