# howto

How to do things with NFX framewrok - **by example**.

License: Apache 2.0

[NFX Library on GitHub](https://github.com/aumcode/nfx)

NFX Documentation [http://nfxlib.com](http://nfxlib.com)


The purpose of this repo is to show how to use various **NFX features by example**. 

The major sections of NFX are segregated into separate folders with corresponding names.

In the majority of cases no special documentation is required as projects are well commented and 
self-explanatory. Just browse the projects source - all help is in the comments
and local markdowns (if any).

Unless otherwise noted (e.g. for MySQL and Mongo DB), **no 3rd party installation of any software (including Nuget)**
is required as NFX is a self-contained system that relies only on .NET framework (and Net Core support is in plans for 2018)

NOTE:

When profiling .NET server applications, do not forget to enable **SERVER GC** by adding the following
items to your App.config (this is already done for the projects in this solution):

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <runtime>
    <gcServer enabled="true"/> <!-- ADD THIS to enable SERVER GC -->
  </runtime>
  <startup> 
      .................................
  </startup>
</configuration>
```

