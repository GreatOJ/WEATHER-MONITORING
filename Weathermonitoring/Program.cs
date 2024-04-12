using System;
using Weathersystem;

namespace Weathermonitoring;
class Program
{
    static void Main(string[] args)
    {
        // Create WeatherData singleton instance
        WeatherData weatherData = WeatherData.GetInstance();

        // Create WeatherStation factory instance
        WeatherStation weatherStation = new WeatherStation();

        // Create displays using factory pattern
        IDisplay currentConditionsDisplay = weatherStation.CreateDisplay("CurrentConditions", weatherData);
        IDisplay statisticsDisplay = weatherStation.CreateDisplay("Statistics", weatherData);
        IDisplay forecastDisplay = weatherStation.CreateDisplay("Forecast", weatherData);

        // Simulate weather data changes (for simplicity, randomly generated)
        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            float temperature = rnd.Next(0, 40); // Random temperature between 0 and 40
            float humidity = rnd.Next(0, 100); // Random humidity between 0 and 100
            float pressure = rnd.Next(900, 1100); // Random pressure between 900 and 1100

            // Set weather data
            weatherData.SetMeasurements(temperature, humidity, pressure);

            // Wait for a few seconds before updating weather data again
            System.Threading.Thread.Sleep(2000);
        }

        Console.ReadLine();
    }
}
