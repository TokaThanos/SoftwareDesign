namespace CheckoutServiceAbstractFactory.Interfaces
{
    public interface IRegionCheckoutFactory
    {
        public IPaymentGateway CreatePaymentGateway(string gatewayType);
        public IInvoice CreateInvoice();
    }
}
