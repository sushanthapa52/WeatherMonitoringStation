using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_station
{
    /// <summary>
    /// Represents a display showing statistics of temperature.
    /// </summary>
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private List<double> temperatures; // Stores the list of temperatures for calculating statistics.

        /// <summary>
        /// Initializes a new instance of the StatisticsDisplay class.
        /// </summary>
        public StatisticsDisplay()
        {
            temperatures = new List<double>();
        }

        /// <summary>
        /// Updates the display with new temperature data.
        /// </summary>
        /// <param name="temperature">The new temperature value.</param>
        /// <param name="humidity">Unused parameter.</param>
        /// <param name="pressure">Unused parameter.</param>
        public void Update(double temperature, double humidity, double pressure)
        {
            temperatures.Add(temperature);
            Display();
        }

        /// <summary>
        /// Displays the statistics of temperature.
        /// </summary>
        public void Display()
        {
            double maxTemp = temperatures.Count > 0 ? temperatures.Max() : 0;
            double minTemp = temperatures.Count > 0 ? temperatures.Min() : 0;
            double avgTemp = temperatures.Count > 0 ? temperatures.Average() : 0;

            Console.WriteLine($"Max temperature: {maxTemp}, Min temperature: {minTemp}, Average temperature: {avgTemp}");
        }
    }
}
