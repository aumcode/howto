using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX.Glue;

namespace XYZ.BusinessDomain.Contracts
{
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
