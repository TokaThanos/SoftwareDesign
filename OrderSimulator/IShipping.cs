namespace OrderSimulator
{
    internal interface IShipping
    {
        public double GetCost(Order order);
        public DateTime GetDate(Order order);
    }
}