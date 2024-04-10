using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_monitoring_station
{
    /// <summary>
    /// Represents a singleton class that manages weather data and notifies observers.
    /// </summary>
    public class WeatherData : ISubject
    {
        private static WeatherData instance; // Stores the singleton instance of WeatherData.
        private double temperature; // Stores the current temperature.
        private double humidity; // Stores the current humidity.
        private double pressure; // Stores the current pressure.
        private List<IObserver> observers; // Stores the list of observers subscribed to weather updates.

        /// <summary>
        /// Private constructor to prevent external instantiation.
        /// </summary>
        private WeatherData()
        {
            observers = new List<IObserver>();
        }

        /// <summary>
        /// Gets the singleton instance of WeatherData.
        /// </summary>
        /// <returns>The singleton instance of WeatherData.</returns>
        public static WeatherData GetInstance()
        {
            if (instance == null)
            {
                instance = new WeatherData();
            }
            return instance;
        }

        /// <summary>
        /// Sets the latest measurements of temperature, humidity, and pressure.
        /// Notifies observers about the changes.
        /// </summary>
        /// <param name="temperature">The new temperature value.</param>
        /// <param name="humidity">The new humidity value.</param>
        /// <param name="pressure">The new pressure value.</param>
        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            NotifyObservers();
        }

        /// <summary>
        /// Registers an observer to receive weather updates.
        /// </summary>
        /// <param name="observer">The observer to register.</param>
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Removes an observer from receiving weather updates.
        /// </summary>
        /// <param name="observer">The observer to remove.</param>
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// Notifies all registered observers about the latest weather measurements.
        /// </summary>
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
    }
}
