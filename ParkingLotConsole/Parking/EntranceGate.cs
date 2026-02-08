using ParkingLotConsole.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotConsole.Parking
{
    internal class EntranceGate
    {
        public Ticket Enter(Vehicle vehicle, ParkingBuilding building)
        {
            return building.Allocate(vehicle);
        }
    }
}
