namespace PizzaSimulatorDecoratorPattern
{
    public class PlainPizza : IBasePizza
    {
        public double GetCost()
        {
            return 100.00;
        }

        public string GetDescription()
        {
            return "Plain pizza";
        }
    }
}
