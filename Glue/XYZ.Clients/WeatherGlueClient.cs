
/* Auto generated by Glue Client Compiler tool (gluec)
on 6/4/2017 1:28:50 PM at SEXTOD by Anton
Do not modify this file by hand if you plan to regenerate this file again by the tool as manual changes will be lost
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using NFX.Glue;
using NFX.Glue.Protocol;


namespace XYZ.BusinessDomain.Contracts.GluedClients
{
  ///<summary>
  /// Client for glued contract XYZ.BusinessDomain.Contracts.IWeather server.
  /// Each contract method has synchronous and asynchronous versions, the later denoted by 'Async_' prefix.
  /// May inject client-level inspectors here like so:
  ///   client.MsgInspectors.Register( new YOUR_CLIENT_INSPECTOR_TYPE());
  ///</summary>
  public class WeatherGlueClient : ClientEndPoint, @XYZ.@BusinessDomain.@Contracts.@IWeather
  {

  #region Static Members

     private static TypeSpec s_ts_CONTRACT;
     private static MethodSpec @s_ms_GetTodaysWheather_0;
     private static MethodSpec @s_ms_GetWheatherForecast_1;

     //static .ctor
     static WeatherGlueClient()
     {
         var t = typeof(@XYZ.@BusinessDomain.@Contracts.@IWeather);
         s_ts_CONTRACT = new TypeSpec(t);
         @s_ms_GetTodaysWheather_0 = new MethodSpec(t.GetMethod("GetTodaysWheather", new Type[]{ typeof(@System.@String) }));
         @s_ms_GetWheatherForecast_1 = new MethodSpec(t.GetMethod("GetWheatherForecast", new Type[]{ typeof(@System.@String), typeof(@System.@DateTime), typeof(@System.@Int32) }));
     }
  #endregion

  #region .ctor
     public WeatherGlueClient(string node, Binding binding = null) : base(node, binding) { ctor(); }
     public WeatherGlueClient(Node node, Binding binding = null) : base(node, binding) { ctor(); }
     public WeatherGlueClient(IGlue glue, string node, Binding binding = null) : base(glue, node, binding) { ctor(); }
     public WeatherGlueClient(IGlue glue, Node node, Binding binding = null) : base(glue, node, binding) { ctor(); }

     //common instance .ctor body
     private void ctor()
     {

     }

  #endregion

     public override Type Contract
     {
       get { return typeof(@XYZ.@BusinessDomain.@Contracts.@IWeather); }
     }



  #region Contract Methods

         ///<summary>
         /// Synchronous invoker for  'XYZ.BusinessDomain.Contracts.IWeather.GetTodaysWheather'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@XYZ.@BusinessDomain.@Contracts.@WeatherDay' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @XYZ.@BusinessDomain.@Contracts.@WeatherDay @GetTodaysWheather(@System.@String  @area)
         {
            var call = Async_GetTodaysWheather(@area);
            return call.GetValue<@XYZ.@BusinessDomain.@Contracts.@WeatherDay>();
         }

         ///<summary>
         /// Asynchronous invoker for  'XYZ.BusinessDomain.Contracts.IWeather.GetTodaysWheather'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_GetTodaysWheather(@System.@String  @area)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_GetTodaysWheather_0, false, RemoteInstance, new object[]{@area});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'XYZ.BusinessDomain.Contracts.IWeather.GetWheatherForecast'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@XYZ.@BusinessDomain.@Contracts.@WeatherDay[]' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @XYZ.@BusinessDomain.@Contracts.@WeatherDay[] @GetWheatherForecast(@System.@String  @area, @System.@DateTime  @start, @System.@Int32  @days)
         {
            var call = Async_GetWheatherForecast(@area, @start, @days);
            return call.GetValue<@XYZ.@BusinessDomain.@Contracts.@WeatherDay[]>();
         }

         ///<summary>
         /// Asynchronous invoker for  'XYZ.BusinessDomain.Contracts.IWeather.GetWheatherForecast'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_GetWheatherForecast(@System.@String  @area, @System.@DateTime  @start, @System.@Int32  @days)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_GetWheatherForecast_1, false, RemoteInstance, new object[]{@area, @start, @days});
            return DispatchCall(request);
         }


  #endregion

  }//class
}//namespace
