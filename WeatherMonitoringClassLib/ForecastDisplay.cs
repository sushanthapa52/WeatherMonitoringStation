using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_station
{
    /// <summary>
    /// ForecastDisplay class implementing IObserver and IDisplay.
    /// </summary>
    public class ForecastDisplay : IObserver, IDisplay
    {
        public void Update(double temperature, double humidity, double pressure)
        {
            // Implement forecast logic based on current weather data
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Weather forecast: Sunny");
        }
    }
}
