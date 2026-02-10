using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Shape circle = new Circle("Red", 5);
        shapes.Add(circle);
        Shape square = new Square("Blue", 4);
        shapes.Add(square);
        Shape rectangle = new Rectangle("Green", 3, 5);
        shapes.Add(rectangle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The area of the {shape.getColor()} shape is {shape.getArea()}");
        }
    }
}