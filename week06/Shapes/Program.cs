using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 5);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("green", 2, 4);
        shapes.Add(rectangle);
        Circle circle = new Circle("yellow", 6);
        shapes.Add(circle);

        foreach (Shape shape in shapes){
            Console.WriteLine($"Color: {shape.GetColor()}\nArea: {shape.GetArea()}");
        }

    }
}