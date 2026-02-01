using CheckoutServiceAbstractFactory.Interfaces;

namespace CheckoutServiceAbstractFactory.Classes
{
    public class IndiaFactory : IRegionCheckoutFactory
    {
        public IInvoice CreateInvoice()
        {
            return new GSTInvoice();
        }

        public IPaymentGateway CreatePaymentGateway(string gatewayType)
        {
            if (gatewayType == "razorpay")
            {
                return new Razorpay();
            }
            else
            {
                return new PayU();
            }
        }
    }
}
