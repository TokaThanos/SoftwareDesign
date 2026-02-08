using ParkingLotConsole.Entity;
using ParkingLotConsole.LookUpStrategy;

namespace ParkingLotConsole.SpotManager
{
    internal abstract class ParkingSpotManager
    {
        private List<ParkingSpot> _spots;
        private IParkingSpotLookUpStrategy _lookUpStrategy;

        protected ParkingSpotManager(List<ParkingSpot> spots, IParkingSpotLookUpStrategy lookUpStrategy)
        {
            _spots = spots;
            _lookUpStrategy = lookUpStrategy;
        }

        public ParkingSpot? Park()
        {
            List<ParkingSpot> candidateSpots = _lookUpStrategy.SelectSpots(_spots);
            foreach (ParkingSpot spot in candidateSpots)
            {
                if (spot.TryOccupySpot())
                {
                    Console.WriteLine($"Successfully secured spot with id {spot.Id}");
                    return spot;
                }
                Console.WriteLine($"Spot id {spot.Id} was taken. Trying next...");
            }
            return null;
        }

        public void UnPark(ParkingSpot spot)
        {
            spot.ReleaseSpot();
        }

        public bool hasFreeSpot()
        {
            return _spots.Any(spot => spot.IsSpotFree());
        }
    }
}
