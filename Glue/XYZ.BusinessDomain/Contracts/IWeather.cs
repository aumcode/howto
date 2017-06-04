using System;

using NFX.Glue;

namespace XYZ.BusinessDomain.Contracts
{
  // WCF Users: notice no [OperationContract], [DataContract] attributes.
  // The payload serialization is polymorphic and automatic as Glue is not 
  // purposed for "one size fits all" tasks such as SOAP, REST etc. (which it does not support),
  // consequently Glue is much simpler and faster than WCF


  /// <summary>
  /// Declares a service that returns weather
  /// </summary>
  [Glued]
  public interface IWeather
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
