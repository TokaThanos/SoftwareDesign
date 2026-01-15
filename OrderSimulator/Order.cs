namespace OrderSimulator
{
    public class Order
    {
        private List<Item> items;
        private IShipping shipping;

        public Order(List<Item> items)
        {
            this.items = items;
            shipping = new GroundShipping();
        }

        public double GetTotalCost()
        {
            double totalCost = 0;
            foreach (var item in items)
            {
                totalCost = totalCost + (item.Quantity * item.Price);
            }
            return totalCost;
        }

        public double GetTotalWeight()
        {
            double totalWeight = 0;
            foreach (var item in items)
            {
                totalWeight = totalWeight + (item.Quantity * item.Weight);
            }
            return totalWeight;
        }

        public double GetShippingCost()
        {
            return shipping.GetCost(this);
        }

        public DateTime GetShippingDate()
        {
            return shipping.GetDate(this);
        }
    }
}
