using System;

namespace Weathersystem
{
    // StatisticsDisplay class
    public class StatisticsDisplay : IDisplay
    {
        private WeatherData weatherData;
        private float totalTemperature;
        private float totalHumidity;
        private float totalPressure;
        private int numberOfUpdates;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            // Update statistics with new weather data
            totalTemperature += temperature;
            totalHumidity += humidity;
            totalPressure += pressure;
            numberOfUpdates++;

            // Update display when weather data changes
            Display();
        }

        public void Display()
        {
            // Calculate average statistics
            float averageTemperature = totalTemperature / numberOfUpdates;
            float averageHumidity = totalHumidity / numberOfUpdates;
            float averagePressure = totalPressure / numberOfUpdates;

            // Display statistics
            Console.WriteLine("Statistics:");
            Console.WriteLine($"Average Temperature: {averageTemperature}°C");
            Console.WriteLine($"Average Humidity: {averageHumidity}%");
            Console.WriteLine($"Average Pressure: {averagePressure} hPa");
        }
    }
}
