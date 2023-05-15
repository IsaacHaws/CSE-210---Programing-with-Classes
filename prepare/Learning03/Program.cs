using System;

class Program
{
    static void Main(string[] args)
    {
        Function fraction1 = new Function();
        Function fraction2 = new Function(5);
        Function fraction3 = new Function(3, 4);
        Function fraction4 = new Function(1, 3);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine();
        
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine();

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine();

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
        Console.WriteLine();
    
        fraction3.GetTop();
        fraction3.GetBottom();
        Console.WriteLine();
        
        fraction4.SetTop(12);
        fraction4.SetBottom(5);

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
    
    
    
    }
}