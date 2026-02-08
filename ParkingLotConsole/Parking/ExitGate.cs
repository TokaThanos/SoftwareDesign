using ParkingLotConsole.Entity;
using ParkingLotConsole.Payment;
using ParkingLotConsole.PricingStrategy;

namespace ParkingLotConsole.Parking
{
    internal class ExitGate
    {
        private readonly IPricingStrategy _strategy;

        public ExitGate(IPricingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void CompleteExit(ParkingBuilding building, Ticket ticket, IPayment payment)
        {
            double amount = _strategy.CalculateAmount(ticket);
            bool isSuccess = payment.Pay(amount);
            if (!isSuccess)
            {
                throw new Exception("Payment failed! Exit denied.");
            }
            building.Release(ticket);
            Console.WriteLine("Exit successful!");
        }
    }
}
