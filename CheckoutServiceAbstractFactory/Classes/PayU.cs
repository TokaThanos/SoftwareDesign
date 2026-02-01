using CheckoutServiceAbstractFactory.Interfaces;

namespace CheckoutServiceAbstractFactory.Classes
{
    internal class PayU : IPaymentGateway
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment processed through PayU");
        }
    }
}
