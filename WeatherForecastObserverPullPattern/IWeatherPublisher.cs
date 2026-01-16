using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastObserverPullPattern
{
    internal interface IWeatherPublisher
    {
        public void AddSubscriber(IWeatherSubscriber subscriber);
        public void RemoveSubscriber(IWeatherSubscriber subscriber);
        public void NotifySubscribers();
        public void SetWeatherData(double temperature, double humidity);
    }
}
