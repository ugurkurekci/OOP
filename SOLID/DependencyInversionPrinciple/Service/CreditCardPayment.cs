using SOLID.DependencyInversionPrinciple.Interface;

namespace SOLID.DependencyInversionPrinciple.Service;

// IPaymentMethod arayüzünü uygular. Her ödeme yöntemi,kendi ödeme işlemlerini ProcessPayment metodunda gerçekleştirir.

public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        // Kredi kartı ile ödeme işlemleri
        Console.WriteLine($"CreditCard ile {amount} tutarında ödeme alındı.");

    }
}