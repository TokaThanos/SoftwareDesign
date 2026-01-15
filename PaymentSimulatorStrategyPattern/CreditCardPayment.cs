using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSimulatorStrategyPattern
{
    public class CreditCardPayment : IPayment
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Paid {amount} rs with credit card");
        }
    }
}
