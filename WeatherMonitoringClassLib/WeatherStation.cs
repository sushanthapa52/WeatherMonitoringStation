using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_station
{
    /// <summary>
    /// WeatherStation class responsible for creating different types of displays.
    /// </summary>
    public class WeatherStation
    {
        public IDisplay CreateDisplay(string displayType)
        {
            switch (displayType)
            {
                case "CurrentConditions":
                    return new CurrentConditionsDisplay();
                case "Statistics":
                    return new StatisticsDisplay();
                case "Forecast":
                    return new ForecastDisplay();
                default:
                    throw new ArgumentException("Invalid display type");
            }
        }
    }
}
