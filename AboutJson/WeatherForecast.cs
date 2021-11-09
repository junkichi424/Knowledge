
public class WeatherForecast
{
    public DateTime Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string Summary { get; set; }
    public Temperatureranges TemperatureRanges { get; set; }
    public string[] MustItems { get; set; }
}

public class Temperatureranges
{
    public Cold Cold { get; set; }
    public Hot Hot { get; set; }
}

public class Cold
{
    public int High { get; set; }
    public int Low { get; set; }
}

public class Hot
{
    public int High { get; set; }
    public int Low { get; set; }
}
