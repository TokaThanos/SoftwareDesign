using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSimulatorDecoratorPattern
{
    public interface IBasePizza
    {
        public string GetDescription();
        public double GetCost();
    }
}
