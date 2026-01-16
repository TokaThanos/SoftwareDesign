using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastObserverPullPattern
{
    public class WeatherForecastStation : IWeatherPublisher
    {
        private List<IWeatherSubscriber> _subscribers;
        private double _temperature;
        private double _humidity;
        public WeatherForecastStation()
        {
            _subscribers = new List<IWeatherSubscriber>();
            _temperature = 0.0;
            _humidity = 0.0;
        }
        public void AddSubscriber(IWeatherSubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (IWeatherSubscriber subscriber in _subscribers)
            {
                subscriber.Update();
            }
        }

        public void RemoveSubscriber(IWeatherSubscriber subscriber)
        {
            _subscribers?.Remove(subscriber);
        }

        public void SetWeatherData(double temperature, double humidity)
        {
            _temperature = temperature;
            _humidity = humidity;
            NotifySubscribers();
        }

        public double GetTemperature()
        {
            return _temperature;
        }

        public double GetHumidity()
        {
            return _humidity;
        }
    }
}
