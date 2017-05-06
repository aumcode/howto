using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX;
using NFX.IO;
using NFX.ApplicationModel;
using NFX.Environment;

namespace ConsoleSkeleton
{
  /// <summary>
  /// This is a skeleton of a typical NFX console app.
  /// It demonstrates:
  ///   a. Setting up an application
  ///   b. Writing highlighted content: help etc.
  ///   c. Using command line arguments
  ///   d. Injecting dependency -  inject logic module from command line with configuration
  ///   e. Handling Errors
  /// </summary>
  /// <example>
  ///   ConsoleSkeleton -logic type="ConsoleSkeleton.CountLogic, ConsoleSkeleton" from=5 to=15
  ///   ConsoleSkeleton -logic type="ConsoleSkeleton.SaySomethingLogic, ConsoleSkeleton" what-to-say="Yes, This is my yellow message" primary-color=yellow
  /// </example>
  class Program
  {
    static int Main(string[] args)
    {
      try
      {
        using (var app = new ServiceBaseApplication(args, null))//explicit rootConfig = null - will search the co-located file
          run(app);

        if (System.Diagnostics.Debugger.IsAttached)
        {
          Console.WriteLine("Strike a key...");
          Console.ReadKey();
        }

        return 0;
      }
      catch(Exception error)
      {
        ConsoleUtils.Error("Program leaked: {0}\n Trace: {1}".Args(error.ToMessageWithType(), error.StackTrace));
        return -1;
      }
    }

    private static void run(ServiceBaseApplication app)
    {
      if (app.CommandArgs["?", "h", "help"].Exists)
      {
        //GetText is an extension method that reads an embedded resource
        //relative to the specfied type location
        ConsoleUtils.WriteMarkupContent(typeof(Program).GetText("Help.txt"));
        return;
      }

      var silent = app.CommandArgs["s", "silent"].Exists;
      if (!silent) 
        ConsoleUtils.WriteMarkupContent(typeof(Program).GetText("Welcome.txt")); 
      
      if (!silent) Console.WriteLine();

      //Get logic switch ' -logic' from command args line as config section
      //notice no if statements, if nodes does not exist, sentinels are returned
      //we could use if (cfgLogic.Exists)....
      var cfgLogic = app.CommandArgs["logic"];

      //Inject the logic from config, use DefaultLogic if type is not specified
      //this will call Configure(cfgLogic) on the Logic instance
      var logic = FactoryUtils.MakeAndConfigure<Logic>(cfgLogic, typeof(DefaultLogic));

      //execute injected logic module
      logic.Execute();

      if (!silent) ConsoleUtils.Info("The End");
    }

  }


}
