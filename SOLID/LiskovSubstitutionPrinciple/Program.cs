using SOLID.LiskovSubstitutionPrinciple.Interface;
using SOLID.LiskovSubstitutionPrinciple.Value;

namespace SOLID.LiskovSubstitutionPrinciple;

class Program
{
    static void Main(string[] args)
    {
        IShape rectangle = new Rectangle();
        ((IRectangle)rectangle).Width = 5;
        ((IRectangle)rectangle).Height = 10;
        Console.WriteLine($"Rectangle Area: {rectangle.Area()}");

        IShape square = new Square();
        ((ISquare)square).Side = 5;
        Console.WriteLine($"Square Area: {square.Area()}");

        IShape triangle = new Triangle();
        ((ITriangle)triangle).Base = 40;
        ((ITriangle)triangle).Height = 10;
        Console.WriteLine($"Triangle Area: {triangle.Area()}");
        Console.ReadLine();
    }
}