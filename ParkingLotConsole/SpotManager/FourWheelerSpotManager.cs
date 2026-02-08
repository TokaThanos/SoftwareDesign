using ParkingLotConsole.Entity;
using ParkingLotConsole.LookUpStrategy;

namespace ParkingLotConsole.SpotManager
{
    internal class FourWheelerSpotManager : ParkingSpotManager
    {
        public FourWheelerSpotManager(List<ParkingSpot> spots, ParkingSpotLookUpStrategy lookUpStrategy) : base(spots, lookUpStrategy) { }
    }
}
