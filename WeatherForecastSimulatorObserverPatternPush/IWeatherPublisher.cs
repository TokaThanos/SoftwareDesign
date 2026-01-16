using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastSimulatorObserverPatternPush
{
    internal interface IWeatherPublisher
    {
        public void AddSubscriber(IWeatherSubscriber subscriber);
        public void RemoveSubscriber(IWeatherSubscriber subscriber);
        public void NotifySubscriber();
        public void SetWeatherReading(double temperature, double humidity);
    }
}
