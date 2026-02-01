using CheckoutServiceAbstractFactory.Interfaces;

namespace CheckoutServiceAbstractFactory.Classes
{
    public class USFactory : IRegionCheckoutFactory
    {
        public IInvoice CreateInvoice()
        {
            return new USInvoice();
        }

        public IPaymentGateway CreatePaymentGateway(string gatewayType)
        {
            if (gatewayType == "stripe")
            {
                return new Stripe();
            }
            else
            {
                return new PayPal();
            }
        }
    }
}
