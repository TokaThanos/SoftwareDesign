namespace PizzaSimulatorDecoratorPattern
{
    public class Farmhouse : IBasePizza
    {
        public double GetCost()
        {
            return 135.00;
        }

        public string GetDescription()
        {
            return "Farmhouse pizza";
        }
    }
}
