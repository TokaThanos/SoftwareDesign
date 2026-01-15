using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSimulatorStrategyPattern
{
    public class ShoppingCart
    {
        private IPayment _paymentMethod;

        public ShoppingCart(IPayment paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void Checkout(int amount)
        {
            _paymentMethod.Pay(amount);
        }
    }
}
