using SOLID.DependencyInversionPrinciple.Interface;

namespace SOLID.DependencyInversionPrinciple.Service;

// IPaymentMethod arayüzünü uygular. Her ödeme yöntemi,kendi ödeme işlemlerini ProcessPayment metodunda gerçekleştirir.
public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        // PayPal ile ödeme işlemleri
        Console.WriteLine($"PayPal ile {amount} tutarında ödeme alındı.");
    }
}