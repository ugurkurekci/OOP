using SOLID.SingleResponsibilityPrinciple.Model;
using SOLID.SingleResponsibilityPrinciple.Repository;
using SOLID.SingleResponsibilityPrinciple.Service;

namespace SOLID.SingleResponsibilityPrinciple;

class Program
{
    static void Main(string[] args)
    {
        ProductRepository repository = new ProductRepository();
        ProductReportGenerator reportGenerator = new ProductReportGenerator();

        Product product = new Product { Id = 1, Name = "Example Product", Price = 50.99m };

        repository.SaveProduct(product);
        reportGenerator.GenerateProductReport(product);

        Console.ReadLine();
    }
}
