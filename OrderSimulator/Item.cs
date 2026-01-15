namespace OrderSimulator
{
    public class Item
    {
        public string Name { get; }
        public double Price { get; }
        public double Weight { get; }
        public int Quantity { get; }

        public Item(string name, double price, double weight, int quantity)
        {
            Name = name;
            Price = price;
            Weight = weight;
            Quantity = quantity;
        }
    }
}