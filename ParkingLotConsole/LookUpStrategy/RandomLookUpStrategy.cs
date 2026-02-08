using ParkingLotConsole.Entity;

namespace ParkingLotConsole.LookUpStrategy
{
    class RandomLookUpStrategy : IParkingSpotLookUpStrategy
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
