using System;


public class Resistor : Part {
    protected string _resistance;
    private string _powerWatts;
    private string _type;

    
    public Resistor(string resistance) {
        _resistance = resistance;
    }

    public Resistor(string maker, string package, string tolerance, string resistance, string powerWatts, string type): base(maker, package, tolerance) {
        _resistance = resistance;
        _powerWatts = powerWatts;
        _type = type;
    }


    protected string GetResistance() {
        return _resistance;
    }

    protected string GetPowerWatts() {
        return _powerWatts;
    }    

    protected string GetPartType() {
        return _type;
    }



    public override void AddPart() {
        
    }

    public override string GetInfo() {
        return "";
    }

    public override void DisplayPart() {

    }
}