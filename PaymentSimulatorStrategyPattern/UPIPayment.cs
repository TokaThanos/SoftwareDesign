namespace PaymentSimulatorStrategyPattern
{
    public class UPIPayment : IPayment
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Paid {amount} rs with UPI");
        }
    }
}
