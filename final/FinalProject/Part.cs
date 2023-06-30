using System;


public class Part {
    private string _manufacturer;
    private string _package;
    private string _tolerance;


    public Part() {
        Console.Write("Who is the maker of the part? ");
        _manufacturer = Console.ReadLine();

        Console.Write("What is the package number? ");
        _package = Console.ReadLine();

        Console.Write("What is the tolerance of the part? ");
        _tolerance = Console.ReadLine();
    }

    public Part(string maker, string package, string tolerance) {
        _manufacturer = maker;
        _package = package;
        _tolerance = tolerance;
    }

    
    protected string GetManufacturer() {
        return _manufacturer;
    }

    protected string GetPackage() {
        return _package;
    }

    protected string GetTolerance() {
        return _tolerance;
    }


    
    public virtual void AddPart() {

    }

    public virtual string GetInfo() {
        return $"{GetManufacturer()},{GetPackage()},{GetTolerance()}";
    }

    public virtual void DisplayPart() {
        Console.WriteLine($"Manufacturer: {GetManufacturer()} Package: {GetPackage()} Tolerance: {GetTolerance()}");
    }
}