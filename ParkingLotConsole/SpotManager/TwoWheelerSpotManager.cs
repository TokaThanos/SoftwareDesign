using ParkingLotConsole.Entity;
using ParkingLotConsole.LookUpStrategy;

namespace ParkingLotConsole.SpotManager
{
    internal class TwoWheelerSpotManager : ParkingSpotManager
    {
        public TwoWheelerSpotManager(List<ParkingSpot> spots, IParkingSpotLookUpStrategy lookUpStrategy) : base(spots, lookUpStrategy) { }
    }
}
