using CheckoutServiceAbstractFactory.Interfaces;

namespace CheckoutServiceAbstractFactory.Service
{
    public class CheckoutService
    {
        private IInvoice _invoice;
        private IPaymentGateway _paymentGateway;
        private IRegionCheckoutFactory _factory;

        public CheckoutService(IRegionCheckoutFactory factory, string paymentMode)
        {
            _factory = factory;
            _paymentGateway = factory.CreatePaymentGateway(paymentMode);
            _invoice = factory.CreateInvoice();
        }

        public void CompleteOrder()
        {
            _paymentGateway.ProcessPayment();
            _invoice.GenerateInvoice();
        }
    }
}
