using SOLID.DependencyInversionPrinciple.Interface;
using SOLID.DependencyInversionPrinciple.Service;
using SOLID.DependencyInversionPrinciple.SOLID;

namespace DependencyInversionPrinciple;

class Program
{
    static void Main(string[] args)
    {
        IPaymentMethod creditCardPayment = new CreditCardPayment();
        IPaymentMethod payPalPayment = new PayPalPayment();

        PaymentProcessor paymentProcessor1 = new PaymentProcessor(creditCardPayment);
        PaymentProcessor paymentProcessor2 = new PaymentProcessor(payPalPayment);
        
        decimal amount = 100.00m;

        paymentProcessor1.ProcessPayment(amount);
        paymentProcessor2.ProcessPayment(amount);

        Console.ReadLine();
    }
}