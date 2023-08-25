using SOLID.InterfaceSegregationPrinciple.Interface;
using SOLID.InterfaceSegregationPrinciple.Service;
using SOLID.InterfaceSegregationPrinciple.SOLID;

namespace SOLID.InterfaceSegregationPrinciple;

class Program
{
    static void Main(string[] args)
    {
        IPrinter printer = new Printer();
        printer.Print();
        Console.WriteLine("**********");
        IFaxMachine faxMachine = new MultiFunctionDevice();
        faxMachine.Fax();
        Console.WriteLine("**********");
        IScanner scanner = new MultiFunctionDevice();
        scanner.Scan();
        Console.ReadLine();
    }
}