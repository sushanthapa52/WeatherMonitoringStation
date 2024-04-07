using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_station
{
    /// <summary>
    /// CurrentConditionsDisplay class implementing IObserver and IDisplay.
    /// </summary>
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private double temperature;
        private double humidity;
        private double pressure;

        public void Update(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
        }
    }
}
