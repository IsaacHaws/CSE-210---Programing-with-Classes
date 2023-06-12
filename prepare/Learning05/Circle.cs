using System;


public class Circle : Shape {
    private double _raduis;


    public Circle(string color, double raduis): base(color) {
        _raduis = raduis;
    }


    public override double GetArea()
    {
        return (_raduis * _raduis) * Math.PI;
    }
}