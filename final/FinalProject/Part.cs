using System;


public class Part {
    private string _manufacturer;
    private string _package;
    private string _tolerance;
    private int _quantity;


    public Part() {
        Console.Write("Who is the maker of the part? ");
        _manufacturer = Console.ReadLine();

        Console.Write("What is the package number? ");
        _package = Console.ReadLine();

        Console.Write("What is the tolerance of the part? ");
        _tolerance = Console.ReadLine();

        Console.Write("How many would you like to add to your invertory? ");
        _quantity = int.Parse(Console.ReadLine());
    }

    public Part(string maker, string package, string tolerance, int quantity) {
        _manufacturer = maker;
        _package = package;
        _tolerance = tolerance;
        _quantity = quantity;
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

    protected int GetQuantity() {
        return _quantity;
    }


    
    public virtual void AddPart() {

    }

    public virtual string GetInfo() {
        return $"{GetManufacturer()},{GetPackage()},{GetTolerance()},{GetQuantity()}";
    }

    public virtual void DisplayPart(int num) {
        Console.WriteLine($"[{num}]. \n" + 
        $"  Manufacturer: {GetManufacturer()}\n" +  
        $"  Package: {GetPackage()}\n" + 
        $"  Tolerance: {GetTolerance()}\n" +
        $"  Quantity: {GetQuantity()}\n");
    }
}