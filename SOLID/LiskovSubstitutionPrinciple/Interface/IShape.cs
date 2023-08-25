namespace SOLID.LiskovSubstitutionPrinciple.Interface;

// Bu arayüz, farklı şekil sınıflarının (örneğin Rectangle, Square) uygulamasını belirten bir şablondur.
// Her şekil sınıfı bu arayüzü uygular ve Area metodu ile kendi alan hesaplamasını gerçekleştirir.

public interface IShape
{
    double Area();
}