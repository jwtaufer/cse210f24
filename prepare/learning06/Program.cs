using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Shape square = new Square("red", 5);
        shapes.Add(square);

        Shape rectangle = new Rectangle("yellow", 5, 7);
        shapes.Add(rectangle);

        Shape circle = new Circle("blue", 2);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"The area of this {shape.GetColor()} {shape} is {shape.GetArea()} units squared.");
        }
    }
}