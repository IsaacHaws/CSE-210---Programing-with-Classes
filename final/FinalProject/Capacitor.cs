using System;


public class Capacitor : Part {
    private string _capacitance;
    private string _ratedVoltage;
    private string _tempCoefficient;

    
    //Constructor to ask the user for class variable values
    public Capacitor() {
        Console.Write("What is the capacitance of the capacitor? ");
        _capacitance = Console.ReadLine();

        Console.Write("What is the rated voltage of the capacitor? ");
        _ratedVoltage = Console.ReadLine();

        Console.Write("What is the temperture coefficient value of the capacitor? ");
        _tempCoefficient = Console.ReadLine();
    }
    
    //Constructor to get class variable values through parameters
    public Capacitor(string maker, string package, string tolerance, string capacitance, string ratedVoltage, string tempCoefficient, int quantity): base(maker, package, tolerance, quantity) {
        _capacitance = capacitance;
        _ratedVoltage = ratedVoltage;
        _tempCoefficient = tempCoefficient;
    }


    //Return the value "_capacitance"
    protected string GetCapacitance() {
        return _capacitance;
    }

    //Return the value of "_ratedVoltage"
    protected string GetRatedVoltage() {
        return _ratedVoltage;
    }

    //Return the value of "_tempCoefficient"
    protected string GetTempCoefficient() {
        return _tempCoefficient;
    }



    public override void AddPart() {
        
    }

    //Return the class info in CSV form
    public override string GetInfo() {
        return $"Capacitor,{GetManufacturer()},{GetPackage()},{GetTolerance()},{GetCapacitance()},{GetRatedVoltage()},{GetTempCoefficient()},{GetQuantity()}";
    }

    //Display part info
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