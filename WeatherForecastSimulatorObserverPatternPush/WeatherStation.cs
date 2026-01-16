using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastSimulatorObserverPatternPush
{
    public class WeatherStation : IWeatherPublisher
    {
        private List<IWeatherSubscriber> _subscribers;
        private WeatherData _data;

        public WeatherStation()
        {
            _subscribers = new List<IWeatherSubscriber>();
            _data = new WeatherData(0.0, 0.0);
        }

        public void AddSubscriber(IWeatherSubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void NotifySubscriber()
        {
            foreach (IWeatherSubscriber subscriber in _subscribers)
            {
                subscriber.Update(_data);
            }
        }

        public void RemoveSubscriber(IWeatherSubscriber subscriber)
        {
            _subscribers?.Remove(subscriber);
        }

        public void SetWeatherReading(double temperature, double humidity)
        {
            _data = new WeatherData(temperature, humidity);
            NotifySubscriber();
        }
    }
}
