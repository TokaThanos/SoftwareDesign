using ParkingLotConsole.Entity;
using ParkingLotConsole.LookUpStrategy;
using ParkingLotConsole.Parking;
using ParkingLotConsole.Payment;
using ParkingLotConsole.PricingStrategy;
using ParkingLotConsole.SpotManager;

namespace ParkingLotConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ParkingSpot> spots = new List<ParkingSpot>
            {
                new ParkingSpot("2S1"),
                new ParkingSpot("2S2"),
                new ParkingSpot("2S3")
            };

            ParkingSpotManager groundLevelTwoWheelerManager = new TwoWheelerSpotManager(spots, new RandomLookUpStrategy());

            spots = new List<ParkingSpot>
            {
                new ParkingSpot("2S1"),
                new ParkingSpot("2S2"),
                new ParkingSpot("2S3")
            };

            ParkingSpotManager firstLevelTwoWheelerManager = new TwoWheelerSpotManager(spots, new RandomLookUpStrategy());

            spots = new List<ParkingSpot>
            {
                new ParkingSpot("4S1"),
                new ParkingSpot("4S2"),
                new ParkingSpot("4S3")
            };

            ParkingSpotManager firstLevelFourWheelerManager = new FourWheelerSpotManager(spots, new RandomLookUpStrategy());

            var groundLevelManagers = new Dictionary<VehicleType, ParkingSpotManager?>()
            {
                { VehicleType.TwoWheeler, groundLevelTwoWheelerManager },
                { VehicleType.FourWheeler, null }
            };

            var firstLevelManagers = new Dictionary<VehicleType, ParkingSpotManager?>()
            {
                { VehicleType.TwoWheeler, firstLevelTwoWheelerManager },
                { VehicleType.FourWheeler, firstLevelFourWheelerManager }
            };

            List<ParkingLevel> parkingLevels = new List<ParkingLevel>()
            {
                new ParkingLevel(1, groundLevelManagers),
                new ParkingLevel(2, firstLevelManagers)
            };

            ParkingBuilding parkingBuilding = new ParkingBuilding(parkingLevels);

            ParkingLot parkingLot = new ParkingLot(new EntranceGate(), parkingBuilding, new ExitGate(new FixedPriceStrategy()));

            Vehicle bike = new Vehicle("WB14A3211", VehicleType.TwoWheeler);
            Vehicle car = new Vehicle("WB13D3907", VehicleType.FourWheeler);

            Ticket ticket1 = parkingLot.VehicleArrives(bike);
            Ticket ticket2 = parkingLot.VehicleArrives(car);

            parkingLot.VehicleExits(bike, ticket1, new CashPay());
            parkingLot.VehicleExits(car, ticket2, new UPIPay());
        }
    }
}
