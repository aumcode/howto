# ConsoleSkeleton

See (Program.cs)[Program.cs]

This is a skeleton for a typical NFX console application.

It demonstrates:

* Setting up an application
* Writing highlighted content: help etc.
* Using command line arguments
* Injecting dependency -  inject logic module from command line with configuration
* Handling Errors
  
  
Example:  
  
```json
  ConsoleSkeleton -logic type="ConsoleSkeleton.CountLogic, ConsoleSkeleton" from=5 to=15
```

```json 
 ConsoleSkeleton -logic type="ConsoleSkeleton.SaySomethingLogic, ConsoleSkeleton" what-to-say="Yes, This is my yellow message" primary-color=yellow
```
