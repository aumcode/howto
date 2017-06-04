using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XYZ.BusinessDomain.Contracts;

namespace XYZ.WeatherServer
{
  /// <summary>
  /// Implements XYZ.BusinessDomain.Contracts.IWeather service contract
  /// </summary>
  public class Weather : IWeather
  {
    public WeatherDay GetTodaysWheather(string area)
    {
      throw new NotImplementedException();
    }

    public WeatherDay[] GetWheatherForecast(string area, DateTime start, int days)
    {
      throw new NotImplementedException();
    }
  }
}
