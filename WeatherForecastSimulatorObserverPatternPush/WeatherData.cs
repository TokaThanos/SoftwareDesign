namespace WeatherForecastSimulatorObserverPatternPush
{
    public class WeatherData
    {
        public double Temperature { get; set; }
        public double Humidity { get; set; }

        public WeatherData(double temperature, double humidity)
        {
            Temperature = temperature;
            Humidity = humidity;
        }
    }
}