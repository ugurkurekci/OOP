using SOLID.InterfaceSegregationPrinciple.SOLID;

namespace SOLID.InterfaceSegregationPrinciple.Service;

public class Printer : IPrinter
{

    public void Print()
    {
        // Yazdırma işlemleri
        Console.WriteLine("Yazdırma işlemi başarılı");
    }

}