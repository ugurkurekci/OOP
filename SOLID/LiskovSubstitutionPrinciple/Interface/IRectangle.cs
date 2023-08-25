namespace SOLID.LiskovSubstitutionPrinciple.Interface;

public interface IRectangle : IShape
{
    double Width { get; set; }
    double Height { get; set; }
}