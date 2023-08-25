using SOLID.LiskovSubstitutionPrinciple.Interface;

namespace SOLID.LiskovSubstitutionPrinciple.Value;

//  Bu sınıfın Side adında bir özelliği vardır.
//  Ayrıca Area metodu da uygulanmıştır ve bu metot, kenar uzunluğunu karesi ile çarparak alanı hesaplar.
public class Square : ISquare
{
    public double Side { get; set; }

    public double Area()
    {
        return Side * Side;
    }
}