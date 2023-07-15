using System;


public class Part {
    private string _manufacturer;
    private string _package;
    private string _tolerance;
    private int _quantity;

    //Constructor to ask the user for class variable values
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

    //Constructor to get class variable values through parameters
    public Part(string maker, string package, string tolerance, int quantity) {
        _manufacturer = maker;
        _package = package;
        _tolerance = tolerance;
        _quantity = quantity;
    }

    //Return the value of "_manufacturer"
    protected string GetManufacturer() {
        return _manufacturer;
    }

    //Return the value of "_package"
    protected string GetPackage() {
        return _package;
    }

    //Return the value of "_tolerance"
    protected string GetTolerance() {
        return _tolerance;
    }

    //Return the value of "_quantity"
    protected int GetQuantity() {
        return _quantity;
    }


    
    public virtual void EditQuantity(int number, string action) {
        if(action == "Subtract") {
            _quantity = _quantity - number;
        }
        else if(action == "Add") {
            _quantity = _quantity + number;
        }
        
    }

    //Return the class info in CSV form
    public virtual string GetInfo() {
        return $"Part,{GetManufacturer()},{GetPackage()},{GetTolerance()},{GetQuantity()}";
    }
    
    //Display part info
    public virtual void DisplayPart(int num) {
        Console.WriteLine($"[{num}]. \n" + 
        $"  Manufacturer: {GetManufacturer()}\n" +  
        $"  Package: {GetPackage()}\n" + 
        $"  Tolerance: {GetTolerance()}\n" +
        $"  Quantity: {GetQuantity()}\n");
    }
}