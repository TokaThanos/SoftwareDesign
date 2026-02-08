using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotConsole.Entity
{
    internal class ParkingSpot
    {
        private bool _isOccupied = false;
        private readonly object _spotLock = new object();
        public string Id { get; }

        public ParkingSpot(string spotId)
        {
            Id = spotId;
        }

        public bool TryOccupySpot()
        {
            lock (_spotLock)
            {
                if (!_isOccupied)
                {
                    _isOccupied = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void ReleaseSpot()
        {
            lock (_spotLock)
            {
                _isOccupied = false;
            }
        }

        public bool IsSpotFree()
        {
            lock (_spotLock)
            {
                return !_isOccupied;
            }
        }
    }
}
