using CheckoutServiceAbstractFactory.Interfaces;

namespace CheckoutServiceAbstractFactory.Classes
{
    internal class PayPal : IPaymentGateway
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment processed through Paypal");
        }
    }
}
