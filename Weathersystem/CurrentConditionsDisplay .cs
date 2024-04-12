namespace Weathersystem;


public class CurrentConditionsDisplay : IDisplay
{
    private WeatherData weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        this.weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        // Update display when weather data changes
        Display();
    }

    public void Display()
    {
        // Display current weather conditions
        Console.WriteLine("Current conditions: Temperature " + weatherData.GetTemperature() + "°C, Humidity " + weatherData.GetHumidity() + "%, Pressure " + weatherData.GetPressure() + "hPa");
    }
}