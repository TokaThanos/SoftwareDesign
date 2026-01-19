namespace PizzaSimulatorDecoratorPattern
{
    public class Chicken : ToppingDecorator
    {
        public Chicken(IBasePizza basePizza) : base(basePizza) { }
        public override double GetCost()
        {
            return base.GetCost() + 34.50;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " with chicken";
        }
    }
}
