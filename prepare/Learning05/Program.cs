using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 5);

        //Console.WriteLine(square.GetColor());
        //Console.WriteLine(square.GetArea() + "\n");


        Rectangle rect = new Rectangle("Blue", 4.5, 8.2);

        //Console.WriteLine(rect.GetColor());
        //Console.WriteLine(rect.GetArea() + "\n");


        Circle circle = new Circle("Green", 10.2);

        //Console.WriteLine(circle.GetColor());
        //Console.WriteLine(circle.GetArea());


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rect);
        shapes.Add(circle);


        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The shape is {color} and has an area of {area}\n");
        }
    }
}