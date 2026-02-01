using CheckoutServiceAbstractFactory.Interfaces;

namespace CheckoutServiceAbstractFactory.Classes
{
    internal class USInvoice : IInvoice
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("US invoice generated");
        }
    }
}
