using SOLID.LiskovSubstitutionPrinciple.Interface;

namespace SOLID.LiskovSubstitutionPrinciple.Value;

// Bu sınıfın Width ve Height adında özellikleri vardır.
// Ayrıca Area metodu da uygulanmıştır ve bu metot, genişlik ve yükseklik değerlerini çarparak alanı hesaplar.
public class Rectangle : IRectangle
{
    public virtual double Width { get; set; }
    public virtual double Height { get; set; }

    public double Area()
    {
        return Width * Height;
    }
}