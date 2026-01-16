using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastSimulatorObserverPatternPush

{
    public class StatisticsDisplay : IWeatherSubscriber
    {
        public void Update(WeatherData data)
        {
            Console.WriteLine($"[Statistics] Temperature update : {data.Temperature}C");
        }
    }
}
