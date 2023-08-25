namespace SOLID.LiskovSubstitutionPrinciple.Interface;

public interface ITriangle : IShape
{
    double Base { get; set; }
    double Height { get; set; }
}