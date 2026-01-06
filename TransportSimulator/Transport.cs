namespace TransportSimulator
{
    public class Transport
    {
        private IEngine engine;
        private IDriver driver;
        public Transport(IDriver driver)
        {
            this.driver = driver;
            engine = new CombustionEngine();
        }

        public void Deliver(string destination)
        {
            engine.Move();
            driver.Navigate(destination);
        }
    }
}
