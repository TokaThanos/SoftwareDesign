using ParkingLotConsole.Entity;

namespace ParkingLotConsole.PricingStrategy
{
    internal class FixedPriceStrategy : IPricingStrategy
    {
        public double CalculateAmount(Ticket ticket)
        {
            return 100;
        }
    }
}
