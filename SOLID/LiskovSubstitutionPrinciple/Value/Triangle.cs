using SOLID.LiskovSubstitutionPrinciple.Interface;

namespace SOLID.LiskovSubstitutionPrinciple.Value;

public class Triangle : ITriangle
{
    public double Base { get; set; }
    public double Height { get; set; }

    public double Area()
    {
        return 0.5 * Base * Height;
    }
}