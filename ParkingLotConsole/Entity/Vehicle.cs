using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotConsole.Entity
{
    internal class Vehicle
    {
        public string Number { get; }
        public VehicleType Type { get; }

        public Vehicle(string vehicleNumber, VehicleType vehicleType)
        {
            Number = vehicleNumber;
            Type = vehicleType;
        }
    }
}
