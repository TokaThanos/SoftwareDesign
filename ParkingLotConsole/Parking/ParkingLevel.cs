using ParkingLotConsole.Entity;
using ParkingLotConsole.SpotManager;

namespace ParkingLotConsole.Parking
{
    internal class ParkingLevel
    {
        private Dictionary<VehicleType, ParkingSpotManager?> _managers;
        public int Level { get; }

        public ParkingLevel(int level, Dictionary<VehicleType, ParkingSpotManager?> managers)
        {
            Level = level;
            _managers = managers;
        }

        public ParkingSpot? Park(VehicleType vehicleType)
        {
            ParkingSpotManager? manager = _managers[vehicleType];
            if (manager == null)
            {
                throw new ArgumentException($"No parking manager found for vehicle type {vehicleType}");
            }
            return manager.Park();
        }

        public void UnPark(VehicleType vehicleType, ParkingSpot spot)
        {
            ParkingSpotManager? manager = _managers[vehicleType];
            if (manager != null)
            {
                manager.UnPark(spot);
            }
        }

        public bool HasAvailablity(VehicleType vehicleType)
        {
            ParkingSpotManager? manager = _managers[vehicleType];
            return manager != null && manager.hasFreeSpot();
        }
    }
}
