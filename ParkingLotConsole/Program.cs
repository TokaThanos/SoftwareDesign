using ParkingLotConsole.Entity;
using ParkingLotConsole.LookUpStrategy;
using ParkingLotConsole.SpotManager;

namespace ParkingLotConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ParkingSpot> spots = new List<ParkingSpot>
            {
                new ParkingSpot("L1S1"),
                new ParkingSpot("L1S2"),
                new ParkingSpot("L1S3")
            };

            ParkingSpotManager manager = new TwoWheelerSpotManager(spots, new RandomLookUpStrategy());
            manager.Park();
            manager.Park();
            manager.UnPark(spots[0]);
            manager.Park();
            if (manager.Park() == null)
            {
                Console.WriteLine("All parking spaces are occupied");
            }
        }
    }
}
