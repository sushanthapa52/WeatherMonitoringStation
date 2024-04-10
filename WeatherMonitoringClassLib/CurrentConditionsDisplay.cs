using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_station
{
    /// <summary>
    /// Represents a display showing the current weather conditions.
    /// </summary>
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private double temperature; // Stores the current temperature.
        private double humidity; // Stores the current humidity.
        private double pressure; // Stores the current pressure.

        /// <summary>
        /// Updates the display with new weather data.
        /// </summary>
        /// <param name="temperature">The new temperature value.</param>
        /// <param name="humidity">The new humidity value.</param>
        /// <param name="pressure">The new pressure value.</param>
        public void Update(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        /// <summary>
        /// Displays the current weather conditions.
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"\u001b[31mCurrent conditions: {temperature}F degrees and {humidity}% humidity\u001b[0m");
        }
    }
}
