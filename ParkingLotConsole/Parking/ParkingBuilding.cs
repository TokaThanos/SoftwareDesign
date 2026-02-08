using ParkingLotConsole.Entity;

namespace ParkingLotConsole.Parking
{
    internal class ParkingBuilding
    {
        private readonly List<ParkingLevel> _levels;
        public ParkingBuilding(List<ParkingLevel> levels)
        {
            _levels = levels;
        }

        public Ticket Allocate(Vehicle vehicle)
        {
            foreach (ParkingLevel level in _levels)
            {
                if (level.HasAvailablity(vehicle.Type))
                {
                    var spot = level.Park(vehicle.Type);
                    if (spot != null)
                    {
                        Ticket ticket = new Ticket(vehicle, spot, level);
                        Console.WriteLine($"Parking allocated at level {level.Level} at spot {spot.Id} for vehicle {vehicle.Number}");
                        return ticket;
                    }
                }
            }
            throw new Exception("Parking space full");
        }

        public void Release(Ticket ticket)
        {
            VehicleType type = ticket.Vehicle.Type;
            ParkingSpot spot = ticket.Spot;
            ticket.Level.UnPark(type, spot);
            Console.WriteLine($"Successfully released spot {spot.Id} at level {ticket.Level.Level}");
        }
    }
}
