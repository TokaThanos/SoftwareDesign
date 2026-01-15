namespace PaymentSimulatorStrategyPattern
{
    public class CashPayment : IPayment
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Paid {amount} rs with Cash");
        }
    }
}
