using SOLID.OpenClosedPrinciple.Interface;

namespace SOLID.OpenClosedPrinciple.Service;

// IPaymentMethod arayüzünü uygular.
// Her ödeme yöntemi,kendi ödeme işlemlerini ProcessPayment metodu içinde gerçekleştirir.

public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        // PayPal ile ödeme işlemleri
        Console.WriteLine($"PayPal ile {amount} tutarında ödeme gerçekleştirildi.");
    }
}