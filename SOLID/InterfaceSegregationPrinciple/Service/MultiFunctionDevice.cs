using SOLID.InterfaceSegregationPrinciple.Interface;
using SOLID.InterfaceSegregationPrinciple.SOLID;

namespace SOLID.InterfaceSegregationPrinciple.Service;

public class MultiFunctionDevice : IPrinter, IFaxMachine, IScanner
{
    public void Fax()
    {
        // Faks işlemleri
        Console.WriteLine("Faks işlemleri");
    }

    public void Print()
    {
        // Yazdırma işlemleri
        Console.WriteLine("Yazdırma işlemleri");
    }

    public void Scan()
    {
        // Tarama işlemleri
        Console.WriteLine("Tarama işlemleri");
    }
}