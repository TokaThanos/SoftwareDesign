using ParkingLotConsole.Entity;
using ParkingLotConsole.Payment;

namespace ParkingLotConsole.Parking
{
    internal class ParkingLot
    {
        public EntranceGate EntranceGate { get; }
        public ParkingBuilding ParkingBuilding { get; }
        public ExitGate ExitGate { get; }
        public ParkingLot(EntranceGate entranceGate, ParkingBuilding parkingBuilding, ExitGate exitGate)
        {
            EntranceGate = entranceGate;
            ParkingBuilding = parkingBuilding;
            ExitGate = exitGate;
        }
        public Ticket VehicleArrives(Vehicle vehicle)
        {
            return EntranceGate.Enter(vehicle, ParkingBuilding);
        }

        public void VehicleExits(Vehicle vehicle, Ticket ticket, IPayment payment)
        {
            ExitGate.CompleteExit(ParkingBuilding, ticket, payment);
        }
    }
}
