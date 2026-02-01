namespace LogisticsServiceFactoryPattern
{
    internal class AirLogistics : ILogistics
    {
        public void Send()
        {
            Console.WriteLine("Product in transit through air");
        }
    }
}
