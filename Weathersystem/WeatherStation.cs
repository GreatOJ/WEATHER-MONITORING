 namespace Weathersystem;



 public class WeatherStation
{
    public IDisplay CreateDisplay(string type, WeatherData weatherData)
    {
        if (type.Equals("CurrentConditions"))
        {
            return new CurrentConditionsDisplay(weatherData);
        }
        else if (type.Equals("Statistics"))
        {
            return new StatisticsDisplay(weatherData);
        }
        else if (type.Equals("Forecast"))
        {
            return new ForecastDisplay(weatherData);
        }
        else
        {
            return null;
        }
    }
}