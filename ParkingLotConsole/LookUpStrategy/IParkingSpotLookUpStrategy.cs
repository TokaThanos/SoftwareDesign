using ParkingLotConsole.Entity;

namespace ParkingLotConsole.LookUpStrategy
{
    internal interface IParkingSpotLookUpStrategy
    {
        public List<ParkingSpot> SelectSpots(List<ParkingSpot> spots);
    }
}
