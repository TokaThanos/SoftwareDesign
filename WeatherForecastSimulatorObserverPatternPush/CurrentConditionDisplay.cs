using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastSimulatorObserverPatternPush
{
    public class CurrentConditionDisplay : IWeatherSubscriber
    {
        public void Update(WeatherData data)
        {
            Console.WriteLine($"[Current condition] Temp : {data.Temperature}C, Hum : {data.Humidity}%");
        }
    }
}
