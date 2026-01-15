using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSimulator
{
    internal class AirShipping : IShipping
    {
        public double GetCost(Order order)
        {
            if (order.GetTotalCost() > 2000)
            {
                return 0;
            }
            return Math.Max(450, order.GetTotalWeight() * 3);
        }

        public DateTime GetDate(Order order)
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
