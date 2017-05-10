using System;

using NFX.Glue;

namespace XYZ.BusinessDomain.Contracts
{
  
  /// <summary>
  /// Declare a service that return wheather
  /// </summary>
  [Glued]
  public interface IWheather
  {
    WeatherDay GetTodaysWheather(string area);
    WeatherDay[] GetWheatherForecast(string area, DateTime start, int days);
  }

  public class WeatherDay
  {
    public DateTime AsOfDate         { get; set; }
    public string LocalityName       { get; set; }
    public float TemperatureHighF    { get; set; }
    public float TemperatureLowF     { get; set; }
    public float PrecipitationChance { get; set; }
  }

}
