using Newtonsoft.Json;


MyNewtonsoft.CreateJson();


public class MyNewtonsoft 
{
    public static void CreateJson()
    {
        // オブジェクトを作る
        var oneday = new WeatherForecast();
        oneday.Date = DateTime.Now;
        oneday.Summary = "だいたい晴れかも";
        oneday.MustItems = new string[] {"傘","てるてる坊主" };
        oneday.TemperatureCelsius = 25;

        var temperatureranges = new Temperatureranges()
        {
            Hot = new Hot() {High = 30,Low = 25},
            Cold = new Cold {High = 15,Low = 10 }            
        };
        oneday.TemperatureRanges = temperatureranges;

        // シリアライズする 第2引数インデントをつける
        var json = JsonConvert.SerializeObject(oneday, Formatting.Indented);

        Console.WriteLine(json);
     }
}


