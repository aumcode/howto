using System;

using NFX;
using NFX.Environment;

namespace ConsoleSkeleton
{

  // The ideology of `IConfigurable` allows for configuration from various sources,
  // as this demo shows, the CommandLineArgs is one of the configuration types,
  // therefore this class and its dependents may get configured using file, command args,
  // db or any other configuration source

  /// <summary>
  /// Denotes an abstract configurable Logic module a'la "strategy".
  /// </summary>
  public abstract class Logic : IConfigurable
  {
    [Config(Default = ConsoleColor.Cyan)]//<--- CONFIG with default
    public ConsoleColor PrimaryColor { get; set; }

    //IConfigSectionNode represents a tree level/node from which the configuration of
    //THIS instance should take place
    public void Configure(IConfigSectionNode node)
    {
      ConfigAttribute.Apply(this, node);//this will interpret all [CONFIG] decorations
      //...may add custom config code of any complexity...
    }

    public abstract void Execute();
  }

  // ---------------------------------------------------
  public class DefaultLogic : Logic
  {
    public override void Execute()
    {
      Console.ForegroundColor = PrimaryColor;
      Console.WriteLine("Default Logic Message");
    }
  }

  // ---------------------------------------------------
  // ConsoleSkeleton -logic type = "ConsoleSkeleton.SaySomethingLogic, ConsoleSkeleton" what-to-say="Yes, This is my yellow message" primary-color=yellow
  public class SaySomethingLogic : Logic
  {
    [Config]
    public string WhatToSay { get; set; }

    public override void Execute()
    {
      Console.ForegroundColor = PrimaryColor;
      Console.WriteLine("{0} {1}".Args(App.TimeSource.UTCNow, WhatToSay));
    }
  }

  // ---------------------------------------------------
  // ConsoleSkeleton -logic type="ConsoleSkeleton.CountLogic, ConsoleSkeleton" from=5 to=15
  public class CountLogic : Logic
  {
    [Config(Default = 1)] //<--- CONFIG with default
    public int From { get; set; }

    [Config(Default = 10)]
    public int To { get; set; }

    public override void Execute()
    {
      Console.ForegroundColor = PrimaryColor;
      for (var i = From; i <= To; i++)
        Console.WriteLine("Counting #{0}".Args(i));
    }
  }

}
