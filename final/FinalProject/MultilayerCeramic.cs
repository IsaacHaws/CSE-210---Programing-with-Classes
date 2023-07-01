using System;


public class MultilayerCeramic : Capacitor {


    public MultilayerCeramic() {
       
    }

    public MultilayerCeramic(string maker, string package, string tolerance, string capacitance, string ratedVoltage, string tempCoefficient, int quantity): base(maker, package, tolerance, capacitance, ratedVoltage, tempCoefficient, quantity) {

    }
    
    
    public override void AddPart() {
        
    }

    public override string GetInfo() {
        return "";
    }

    public override void DisplayPart() {

    }
}