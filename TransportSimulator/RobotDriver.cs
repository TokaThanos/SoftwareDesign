namespace TransportSimulator
{
    public class RobotDriver : IDriver
    {
        public void Navigate(string destination)
        {
            Console.WriteLine($"Navigation using robot driver to {destination}");
        }
    }
}
