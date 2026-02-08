using ParkingLotConsole.Entity;

namespace ParkingLotConsole.LookUpStrategy
{
    class RandomLookUpStrategy : ParkingSpotLookUpStrategy
    {
        public List<ParkingSpot> SelectSpots(List<ParkingSpot> spots)
        {
            return spots
                .Where(spot => spot.IsSpotFree())
                .Take(5)
                .ToList();
        }
    }
}
