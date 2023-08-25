using SOLID.OpenClosedPrinciple.Interface;

namespace SOLID.OpenClosedPrinciple.Service;

// Farklı ödeme yöntemlerini işlemek için kullanılır. Açık/Kapalı Prensip'e uygun olarak, yeni ödeme yöntemleri eklenirken PaymentProcessor sınıfının değişmesi gerekmez.

public class PaymentProcessor
{
    public void ProcessPayment(IPaymentMethod paymentMethod, decimal amount)
    {
        paymentMethod.ProcessPayment(amount);
    }
}