namespace SOLID.LiskovSubstitutionPrinciple.Interface;

public interface ISquare : IShape
{
    double Side { get; set; }
}