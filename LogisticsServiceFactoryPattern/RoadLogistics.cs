namespace LogisticsServiceFactoryPattern
{
    internal class RoadLogistics : ILogistics
    {
        public void Send()
        {
            Console.WriteLine("Product in transit through road");
        }
    }
}
