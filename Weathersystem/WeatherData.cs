namespace Weathersystem;


public class WeatherData
{
    private static WeatherData instance;
    private List<IDisplay> displays;
    private float temperature;
    private float humidity;
    private float pressure;

    private WeatherData()
    {
        displays = new List<IDisplay>();
    }

    public static WeatherData GetInstance()
    {
        if (instance == null)
            instance = new WeatherData();
        return instance;
    }

    public void RegisterObserver(IDisplay display)
    {
        displays.Add(display);
    }

    public void RemoveObserver(IDisplay display)
    {
        displays.Remove(display);
    }

    public void NotifyObservers()
    {
        foreach (IDisplay display in displays)
        {
            display.Display();
        }
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    // Method to update weather data (for simplicity, randomly generated)
    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        MeasurementsChanged();
    }

    // Getter methods for weather data
    public float GetTemperature()
    {
        return temperature;
    }

    public float GetHumidity()
    {
        return humidity;
    }

    public float GetPressure()
    {
        return pressure;
    }
}