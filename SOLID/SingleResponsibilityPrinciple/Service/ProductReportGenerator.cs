using SOLID.SingleResponsibilityPrinciple.Model;

namespace SOLID.SingleResponsibilityPrinciple.Service;

// Bu sınıfın sorumluluğu, ürünle ilgili raporları oluşturmaktır.
// Raporda ne tür bilgilerin yer alacağı, nasıl düzenleneceği gibi işlemleri gerçekleştirir.

public class ProductReportGenerator
{

    public void GenerateProductReport(Product product)
    {
        // Ürünle ilgili rapor oluşturma işlemleri
        Console.WriteLine($"Product Report: {product.Name} - {product.Price}");
    }

}