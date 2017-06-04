using System;

using NFX;
using NFX.Parsing;

using XYZ.BusinessDomain.Contracts;

namespace XYZ.WeatherServer
{
  /// <summary>
  /// Implements XYZ.BusinessDomain.Contracts.IWeather service contract.
  /// The IWeather service in Singleton by default, so this class instance will be created only once
  /// </summary>
  public class Weather : IWeather
  {
    public WeatherDay GetTodaysWheather(string area)
    {
      return makeFake(App.TimeSource.UTCNow, area);
    }
    
    public WeatherDay[] GetWheatherForecast(string area, DateTime start, int days)
    {
      var result = new WeatherDay[days];
      for (var i = 0; i < result.Length; i++)
        result[i] = makeFake(start.AddDays(i), area);

      return result;
    }

    //makes fake weather data for the day
    private WeatherDay makeFake(DateTime when, string area)
    {
      return new WeatherDay
      {
        AsOfDate = when,
        LocalityName = "{0} near {1}".Args(area, NaturalTextGenerator.GenerateCityName()),
        PrecipitationChance = ExternalRandomGenerator.Instance.NextScaledRandomInteger(0,100),
        TemperatureLowF = ExternalRandomGenerator.Instance.NextScaledRandomInteger(42, 50),
        TemperatureHighF = ExternalRandomGenerator.Instance.NextScaledRandomInteger(62, 74),
      };
    }
  }
}
