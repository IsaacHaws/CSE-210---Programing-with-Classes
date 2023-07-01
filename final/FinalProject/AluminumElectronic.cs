using System;


public class AluminumElectronic : Capacitor {
    private string _operatingTemp;
    private string _leadSpacing;
    private string _length;


    public AluminumElectronic() {
        
    }

    public string GetOperatingTemp() {
        return _operatingTemp;
    }

    public string GetLeadSpacing() {
        return _leadSpacing;
    }

    public string GetLength() {
        return _length;
    }



    public override void AddPart() {
        
    }

    public override string GetInfo() {
        return "";
    }

    public override void DisplayPart() {

    }
}