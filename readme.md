NUnit 3 Test Project Template for `dotnet new` CLI
==================================================

|              | Status
|--------------|:--------------:
| nuget        | [![NUnit 3 Test Project Template for dotnet-new CLI](https://buildstats.info/nuget/NUnit3.DotNetNew.Template)](https://www.nuget.org/packages/NUnit3.DotNetNew.Template/)

This repository contains a set of project templates to be used when creating projects from .NET Core `dotnet new` command line interface.

Currently, it contains a project template for a NUnit test library targeting .NET Core.

Usage
-----

To install NUnit Project Template from nuget, run command:

```
dotnet new -i NUnit3.DotNetNew.Template
```

To create a NUnit library project from template, run:

```
dotnet new nunit
```

By default it will create NUnit Test Project targeted to `netcoreapp2.0` (which is in preview for now).
You can specify `--framework` command line switch to change targeting:

```
dotnet new nunit --framework netcoreapp1.1
```

To specify new folder name for your NUnit Test Project you can use `-n` switch.
Following command will create `NUnit-Tests` folder and will generate NUnit Test Project there:

```
dotnet new nunit -n NUnit-Tests --framework netcoreapp1.0
```

For more info on `dotnet new` CLI, please see [documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet).

For more info on NUnit testing framework, please see its project or nunit.org website.

License
-------

This packages is distributed under conditions of [MIT license](LICENSE).

