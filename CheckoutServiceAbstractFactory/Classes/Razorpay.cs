using CheckoutServiceAbstractFactory.Interfaces;

namespace CheckoutServiceAbstractFactory.Classes
{
    internal class Razorpay : IPaymentGateway
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment processed through razorpay");
        }
    }
}
