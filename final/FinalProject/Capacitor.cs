using System;


public class Capacitor : Part {
    protected string _capacitance;
    private string _ratedVoltage;
    private string _tempCoefficient;

    
    public Capacitor(string capacitance) {
        _capacitance = capacitance;
    }
    
    public Capacitor(string maker, string package, string tolerance, string capacitance, string ratedVoltage, string tempCoefficient): base(maker, package, tolerance) {
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
        return "";
    }

    public override void DisplayPart() {

    }
}