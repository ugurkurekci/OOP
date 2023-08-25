using SOLID.OpenClosedPrinciple.Interface;

namespace SOLID.OpenClosedPrinciple.Service;

// IPaymentMethod arayüzünü uygular.
// Her ödeme yöntemi,kendi ödeme işlemlerini ProcessPayment metodu içinde gerçekleştirir.

public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        // Kredi kartı ile ödeme işlemleri
        Console.WriteLine($"Credit card payment processed for {amount}");
    }
}