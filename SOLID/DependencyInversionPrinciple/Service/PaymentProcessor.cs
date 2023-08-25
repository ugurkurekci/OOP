using SOLID.DependencyInversionPrinciple.Interface;

namespace SOLID.DependencyInversionPrinciple.SOLID;

// Bu sınıf, IPaymentMethod arayüzüne bağımlıdır. Ancak, bu bağımlılık enjekte edilerek (constructor injection) gerçekleştirilir.
// Bu,PaymentProcessor sınıfının ne tür bir ödeme yöntemi kullanılacağına dair esneklik kazanmasını sağlar. Bağımlılık tersinimi prensibine uygun olarak, yüksek seviye PaymentProcessor sınıfı düşük seviye ödeme yöntemi sınıflarına bağlı olmamaktadır.

public class PaymentProcessor
{

    private readonly IPaymentMethod _paymentMethod;

    public PaymentProcessor(IPaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public void ProcessPayment(decimal amount)
    {
        
        _paymentMethod.ProcessPayment(amount);

    }
}