using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX;
using NFX.Environment;

namespace ConsoleSkeleton
{

  public abstract class Logic : IConfigurable
  {
    [Config(Default = ConsoleColor.Cyan)]//<--- CONFIG with default
    public ConsoleColor PrimaryColor { get; set; }

    public void Configure(IConfigSectionNode node)
    {
      ConfigAttribute.Apply(this, node);//this will interpret all [CONFIG] decorations
      //...may add custom config code of any complexity...
    }

    public abstract void Execute();
  }


  public class DefaultLogic : Logic
  {
    [Config] //<----- CONFIG property
    public string WhatToSay { get; set; }

    public override void Execute()
    {
      Console.ForegroundColor = PrimaryColor;
      Console.WriteLine("Default Logic");
    }
  }


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
