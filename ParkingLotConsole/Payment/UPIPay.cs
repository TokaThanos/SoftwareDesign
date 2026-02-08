namespace ParkingLotConsole.Payment
{
    internal class UPIPay : IPayment
    {
        public bool Pay(double amount)
        {
            Console.WriteLine($"{amount} rs paid successfully through UPI");
            return true;
        }
    }
}
