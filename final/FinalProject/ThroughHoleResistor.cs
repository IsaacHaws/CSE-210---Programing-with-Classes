using System;


public class ThroughHoleResistor : Resistor {
    private string _tempCoefficient;


    public ThroughHoleResistor(string resistance): base(resistance) {
        _resistance = resistance;
    }


    public string GetTempCoefficient() {
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