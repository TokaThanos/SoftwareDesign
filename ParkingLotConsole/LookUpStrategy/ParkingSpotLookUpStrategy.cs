using ParkingLotConsole.Entity;

namespace ParkingLotConsole.LookUpStrategy
{
    internal interface ParkingSpotLookUpStrategy
    {
        public List<ParkingSpot> SelectSpots(List<ParkingSpot> spots);
    }
}
