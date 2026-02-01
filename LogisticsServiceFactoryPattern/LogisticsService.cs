namespace LogisticsServiceFactoryPattern
{
    public class LogisticsService
    {
        public void Send(string mode)
        {
            ILogistics logistics = LogisticsFactory.GetLogistics(mode);
            logistics.Send();
        }
    }
}
