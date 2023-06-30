using System;


public class MultilayerCeramic : Capacitor {


    public MultilayerCeramic(string capacitance): base(capacitance) {
        _capacitance = capacitance;
    }
    
    public override void AddPart() {
        
    }

    public override string GetInfo() {
        return "";
    }

    public override void DisplayPart() {

    }
}