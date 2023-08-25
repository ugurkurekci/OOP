using SOLID.SingleResponsibilityPrinciple.Model;

namespace SOLID.SingleResponsibilityPrinciple.Repository;

// Bu sınıfın sorumluluğu,ürünleri veritabanına kaydetme, silme ve getirme gibi veritabanı işlemlerini gerçekleştirmektir.
// Ürünlerin kalıcı olarak saklandığı yerle ilgili işlevleri içerir.
public class ProductRepository
{

    public void SaveProduct(Product product)
    {
        // Ürünü veritabanına kaydetme işlemleri
        Console.WriteLine($"Saving product: {product.Name}");
    }

    public void DeleteProduct(Product product)
    {
        // Ürünü veritabanından silme işlemleri
        Console.WriteLine($"Deleting product: {product.Name}");
    }

    public Product GetProduct(int productId)
    {
        // Ürünü veritabanından getirme işlemleri
        Console.WriteLine($"Fetching product with ID: {productId}");
        return new Product { Id = productId, Name = "Sample Product", Price = 100 };
    }

}