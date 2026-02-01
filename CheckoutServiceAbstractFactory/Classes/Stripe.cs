using CheckoutServiceAbstractFactory.Interfaces;

namespace CheckoutServiceAbstractFactory.Classes
{
    internal class Stripe : IPaymentGateway
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment processed through stripe");
        }
    }
}
