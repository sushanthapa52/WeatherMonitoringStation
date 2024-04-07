using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_station
{
    /// <summary>
    /// StatisticsDisplay class implementing IObserver and IDisplay.
    /// </summary>
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private List<double> temperatures;

        public StatisticsDisplay()
        {
            temperatures = new List<double>();
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            temperatures.Add(temperature);
            Display();
        }

        public void Display()
        {
            double maxTemp = temperatures.Count > 0 ? temperatures.Max() : 0;
            double minTemp = temperatures.Count > 0 ? temperatures.Min() : 0;
            double avgTemp = temperatures.Count > 0 ? temperatures.Average() : 0;

            Console.WriteLine($"Max temperature: {maxTemp}, Min temperature: {minTemp}, Average temperature: {avgTemp}");
        }
    }
}
