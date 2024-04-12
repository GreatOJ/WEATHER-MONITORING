namespace Weathersystem;



// using System;

public class ForecastDisplay : IDisplay
{
    private WeatherData weatherData;
    private float currentTemperature;
    private float currentHumidity;
    private float currentPressure;

    public ForecastDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        this.weatherData.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        // Update weather data
        this.currentTemperature = temperature;
        this.currentHumidity = humidity;
        this.currentPressure = pressure;

        // Update display when weather data changes
        Display();
    }

    public void Display()
    {
        // Simple forecast logic: just display current weather conditions
        Console.WriteLine("Forecast:");
        Console.WriteLine($"Temperature: {currentTemperature}°C");
        Console.WriteLine($"Humidity: {currentHumidity}%");
        Console.WriteLine($"Pressure: {currentPressure} hPa");
    }
}
