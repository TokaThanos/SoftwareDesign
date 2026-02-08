using ParkingLotConsole.Entity;
using ParkingLotConsole.LookUpStrategy;

namespace ParkingLotConsole.SpotManager
{
    internal class FourWheelerSpotManager : ParkingSpotManager
    {
        public FourWheelerSpotManager(List<ParkingSpot> spots, IParkingSpotLookUpStrategy lookUpStrategy) : base(spots, lookUpStrategy) { }
    }
}
