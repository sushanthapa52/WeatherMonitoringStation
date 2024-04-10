using System;
using System.Collections.Generic;
using Weather_monitoring_station;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Entry point of the application. Sets up the weather station and displays, registers displays as observers to weather data, and simulates weather changes.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method of the application.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();
            WeatherData weatherData = WeatherData.GetInstance();

            // Create and register displays
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
            ForecastDisplay forecastDisplay = new ForecastDisplay();

            weatherData.RegisterObserver(currentDisplay);
            weatherData.RegisterObserver(statisticsDisplay);
            weatherData.RegisterObserver(forecastDisplay);

            // Simulate weather changes
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                double temperature = random.Next(50, 100);
                double humidity = random.Next(0, 100);
                double pressure = random.Next(20, 40);

                weatherData.SetMeasurements(temperature, humidity, pressure);
            }
        }
    }
}
