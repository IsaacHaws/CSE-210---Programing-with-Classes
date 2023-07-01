using System;


public class ChipResistor : Resistor {


    public ChipResistor() {
        
    }

    public ChipResistor(string maker, string package, string tolerance, string resistance, string powerWatts, int quantity): base(maker, package, tolerance, resistance, powerWatts, quantity) {

    }

    public override void AddPart() {
        
    }

    public override string GetInfo() {
        return "";
    }

    public override void DisplayPart() {

    }
}