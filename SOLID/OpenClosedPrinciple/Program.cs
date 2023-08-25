using SOLID.OpenClosedPrinciple.Interface;
using SOLID.OpenClosedPrinciple.Service;

namespace SOLID.OpenClosedPrinciple;

class Program
{
    static void Main(string[] args)
    {
        PaymentProcessor paymentProcessor = new PaymentProcessor();

        IPaymentMethod creditCardPayment = new CreditCardPayment();
        IPaymentMethod payPalPayment = new PayPalPayment();

        decimal amount = 100.00m;

        paymentProcessor.ProcessPayment(creditCardPayment, amount);
        paymentProcessor.ProcessPayment(payPalPayment, amount);

        Console.ReadLine();
    }
}
