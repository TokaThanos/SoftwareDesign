namespace OrderSimulator
{
    internal class GroundShipping : IShipping
    {
        public double GetCost(Order order)
        {
            if (order.GetTotalCost() > 500)
            {
                return 0;
            }
            return Math.Max(50, order.GetTotalWeight() * 1.5);
        }

        public DateTime GetDate(Order order)
        {
            return DateTime.Today.AddDays(7);
        }
    }
}
