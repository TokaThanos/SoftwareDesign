using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSimulatorStrategyPattern
{
    public interface IPayment
    {
        void Pay(int amount);
    }
}
