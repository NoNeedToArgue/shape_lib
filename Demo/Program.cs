using ShapeLib;
using static ShapeLib.ShapeAreaCalculator;

var shapes = new List<IShape>()
{
    new Circle(5),
    new Triangle(5, 5, 9),
    new Rectangle(3, 5),
    new Triangle(3.5, 2.1, 2.8),
    new Rectangle(4, 4)
};

//with interface

IShape shape = shapes[new Random().Next(shapes.Count)];

Console.WriteLine($"{shape.GetType()}\n Area: {shape.Area()}");

if (shape is Triangle)
    Console.WriteLine($"Right: {((Triangle)shape).IsRight()}");

if (shape is Rectangle)
    Console.WriteLine($"Square: {((Rectangle)shape).IsSquare()}");


//with delegate

object obj = shapes[new Random().Next(shapes.Count)];

double shapeArea = CalculateArea(obj);

Console.WriteLine($"{shape.GetType()}\n Area: {shape.Area()}");
