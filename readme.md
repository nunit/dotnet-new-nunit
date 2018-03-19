NUnit 3 Test Project Template for `dotnet new` CLI
==================================================

|                 | Status
|-----------------|:--------------:
| nuget           | [![NUnit 3 Test Project Template for dotnet-new CLI](https://buildstats.info/nuget/NUnit3.DotNetNew.Template)](https://www.nuget.org/packages/NUnit3.DotNetNew.Template/)
| Windows         | [![Build status](https://ci.appveyor.com/api/projects/status/pb11n8ynftdnmlu4/branch/master?svg=true)](https://ci.appveyor.com/project/halex2005/dotnet-new-nunit-g8axg/branch/master)
| Linux & Mac OSX | [![Build Status](https://travis-ci.org/nunit/dotnet-new-nunit.svg?branch=master)](https://travis-ci.org/nunit/dotnet-new-nunit)

This repository contains a set of project templates to be used when creating projects from .NET Core `dotnet new` command line interface (C#, F# and Visual Basic project templates are supported).

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

If you'd like to create F# or VB test project, you can specify project language with `-lang` switch:

```
dotnet new nunit -lang F#
```

> Note that VB doesn't support dashes in project name. If you have `dotnet-new-nunit-example.vbproj` test project, then you'll get compiler error like this:
>
>     vbc : error BC30113: 'dotnet-new-nunit-example' is not a valid name and cannot be used as the root namespace name. [/home/hal/git/dotnet-new-nunit-example/dotnet-new-nunit-example.vbproj]
>
> To workaround this compiler error, rename your project so that it contained no dashes.

For more info on `dotnet new` CLI, please see [documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet).

For more info on NUnit testing framework, please see its project or nunit.org website.

License
-------

This packages is distributed under conditions of [MIT license](LICENSE).

