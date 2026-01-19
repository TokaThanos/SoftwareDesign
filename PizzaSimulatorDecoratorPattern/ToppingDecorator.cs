namespace PizzaSimulatorDecoratorPattern
{
    public abstract class ToppingDecorator : IBasePizza
    {
        private IBasePizza _basePizza;
        protected ToppingDecorator(IBasePizza basePizza)
        {
            _basePizza = basePizza;
        }
        public virtual double GetCost()
        {
            return _basePizza.GetCost();
        }

        public virtual string GetDescription()
        {
            return _basePizza.GetDescription();
        }
    }
}
