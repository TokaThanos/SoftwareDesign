namespace TransportSimulator
{
    public class HumanDriver : IDriver
    {
        public void Navigate(string destination)
        {
            Console.WriteLine($"Navigation using human driver to {destination}");
        }
    }
}
