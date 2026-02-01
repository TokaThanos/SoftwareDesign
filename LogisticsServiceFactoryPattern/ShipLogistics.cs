namespace LogisticsServiceFactoryPattern
{
    internal class ShipLogistics : ILogistics
    {
        public void Send()
        {
            Console.WriteLine("Product shipped through water");
        }
    }
}
