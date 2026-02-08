namespace ParkingLotConsole.Payment
{
    internal class CashPay : IPayment
    {
        public bool Pay(double amount)
        {
            Console.WriteLine($"{amount} rs paid successfully through cash");
            return true;
        }
    }
}
