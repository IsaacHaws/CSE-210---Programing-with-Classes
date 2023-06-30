using System;


public class ChipResistor : Resistor {


    public ChipResistor(string resistance): base(resistance) {
        _resistance = resistance;
    }

    public override void AddPart() {
        
    }

    public override string GetInfo() {
        return "";
    }

    public override void DisplayPart() {

    }
}