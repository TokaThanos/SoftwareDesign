using CheckoutServiceAbstractFactory.Interfaces;

namespace CheckoutServiceAbstractFactory.Classes
{
    internal class GSTInvoice : IInvoice
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("GST invoice generated");
        }
    }
}
