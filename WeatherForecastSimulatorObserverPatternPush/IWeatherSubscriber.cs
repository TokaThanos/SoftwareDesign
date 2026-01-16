using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastSimulatorObserverPatternPush
{
    public interface IWeatherSubscriber
    {
        public void Update(WeatherData data);
    }
}
