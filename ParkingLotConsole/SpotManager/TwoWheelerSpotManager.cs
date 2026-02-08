using ParkingLotConsole.Entity;
using ParkingLotConsole.LookUpStrategy;

namespace ParkingLotConsole.SpotManager
{
    internal class TwoWheelerSpotManager : ParkingSpotManager
    {
        public TwoWheelerSpotManager(List<ParkingSpot> spots, ParkingSpotLookUpStrategy lookUpStrategy) : base(spots, lookUpStrategy) { }
    }
}
