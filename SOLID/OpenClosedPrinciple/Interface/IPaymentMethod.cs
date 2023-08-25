namespace SOLID.OpenClosedPrinciple.Interface;

// Bu arayüz,farklı ödeme yöntemlerinin uygulamasını belirten bir şablondur.
// Her ödeme yöntemi sınıfı bu arayüzü uygular ve ProcessPayment metotunu gerçekleştirir.
public interface IPaymentMethod
{
    void ProcessPayment(decimal amount);
}