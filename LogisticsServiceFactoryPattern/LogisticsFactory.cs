namespace LogisticsServiceFactoryPattern
{
    internal class LogisticsFactory
    {
        public static ILogistics GetLogistics(string mode)
        {
            if (mode == "air")
            {
                return new AirLogistics();
            }
            else if (mode == "water")
            {
                return new ShipLogistics();
            }
            else
            {
                return new RoadLogistics();
            }
        }
    }
}
