using ParkingLotConsole.Entity;

namespace ParkingLotConsole.PricingStrategy
{
    internal interface IPricingStrategy
    {
        double CalculateAmount(Ticket ticket);
    }
}
