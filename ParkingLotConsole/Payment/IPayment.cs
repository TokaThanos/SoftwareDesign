using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotConsole.Payment
{
    internal interface IPayment
    {
        public bool Pay(double amount);
    }
}
