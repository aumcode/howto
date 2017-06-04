using System;

using NFX;
using NFX.ApplicationModel;

namespace XYZ.WeatherServer
{

  //Run this program from command line.
  // You can also experiment with different configuration files which can be injected using `-config` switch:
  //
  // This will use the default config names as EXE entry point
  //  c:\> XYZ.WeatherServer
  //
  // This will use a different config file
  //  c:\> XYZ.WeatherServer  -config "mytest.laconf"
  //
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        //At first, we setup an app container.
        //Glue is built-in app container, so it will automatically inject dependencies and 
        //start the server hosting as listed in config;
        //Passing null to `rootConfig` - explicitly tells container to use the config file co-located with an EXE
        //we could have written config right here, or we could have built service host by hand allocating classes
        using (new ServiceBaseApplication(args, rootConfig: null))
        {
          Console.WriteLine("Server is running, endpoints:");
          Console.WriteLine("-----------------------------");
   
          //Loop through all endpoints served by this application
          foreach (var service in App.Glue.Servers)
            Console.WriteLine("    " + service);

          Console.WriteLine("Hit <enter> to exit");
          Console.ReadLine();
        }
      }
      catch (Exception ex)//we get here in case of error in app config file
      {
        Console.WriteLine("Exception leaked (most likely bad app config):");

        //In NFX exception types represents the component area of the application
        //it is usually enough to know what went wrong just by seeing exception type
        //without looking at stack trace at all
        Console.WriteLine(ex.ToMessageWithType());
        Environment.ExitCode = -1;
      }
    }
  }
}
