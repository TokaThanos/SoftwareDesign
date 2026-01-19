namespace PizzaSimulatorDecoratorPattern
{
    public class Mushroom : ToppingDecorator
    {
        public Mushroom(IBasePizza basePizza) : base(basePizza) { }
        public override double GetCost()
        {
            return base.GetCost() + 23.50;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " with mushroom";
        }
    }
}
