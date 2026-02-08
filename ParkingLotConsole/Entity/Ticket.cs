using ParkingLotConsole.Parking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotConsole.Entity
{
    internal class Ticket
    {
        public Vehicle Vehicle { get; }
        public ParkingSpot Spot { get; }
        public ParkingLevel Level { get; }
        public DateTime EntryTime { get; }

        public Ticket(Vehicle vehicle, ParkingSpot spot, ParkingLevel level)
        {
            Vehicle = vehicle;
            Spot = spot;
            Level = level;
            EntryTime = DateTime.Now;
        }
    }
}
