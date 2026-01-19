namespace PizzaSimulatorDecoratorPattern
{
    public class Cheese : ToppingDecorator
    {
        public Cheese(IBasePizza basePizza) : base(basePizza) { }
        public override double GetCost()
        {
            return base.GetCost() + 25.00;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " with cheese";
        }
    }
}
