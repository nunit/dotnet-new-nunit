NUnit 3 Test Project Template for `dotnet new` CLI
==================================================

|                 | Status         | History |
|-----------------|:--------------:|---------|
| nuget           | [![NUnit 3 Test Project Template for dotnet-new CLI](https://buildstats.info/nuget/NUnit3.DotNetNew.Template)](https://www.nuget.org/packages/NUnit3.DotNetNew.Template/) |
| Windows         | [![Build status](https://ci.appveyor.com/api/projects/status/pb11n8ynftdnmlu4/branch/master?svg=true)](https://ci.appveyor.com/project/halex2005/dotnet-new-nunit-g8axg/branch/master) | [![Build history for appveyor](https://buildstats.info/appveyor/chart/halex2005/dotnet-new-nunit-g8axg?branch=master&includeBuildsFromPullRequest=false)](https://ci.appveyor.com/project/halex2005/dotnet-new-nunit-g8axg/history?branch=master)
| Linux & Mac OSX | [![Build Status](https://travis-ci.org/nunit/dotnet-new-nunit.svg?branch=master)](https://travis-ci.org/nunit/dotnet-new-nunit)                                                        | [![Build history for travis-ci](https://buildstats.info/travisci/chart/nunit/dotnet-new-nunit?branch=master&includeBuildsFromPullRequest=false)](https://travis-ci.org/nunit/dotnet-new-nunit/builds?branch=master)

This repository contains a set of project and item templates to be used when creating projects from .NET Core `dotnet new` command line interface (C#, F# and Visual Basic project templates are supported).

Currently, it contains a project template for a NUnit test library targeting .NET Core.

Installation
------------

To install NUnit Project and Item Templates from nuget, run command:

```
dotnet new -i NUnit3.DotNetNew.Template
```

Usage
-----

### Project Templates

To create new NUnit library project from template, run:

```
dotnet new nunit
```

By default it will create NUnit Test Project targeted to `net5.0`.
You can specify `--framework` command line switch to change targeting:

```
dotnet new nunit --framework netcoreapp3.1
```

To specify new folder name for your NUnit Test Project you can use `-n` switch.
Following command will create `NUnit-Tests` folder and will generate NUnit Test Project there:

```
dotnet new nunit -n NUnit-Tests --framework netcoreapp3.1
```

If you'd like to create F# or VB test project, you can specify project language with `-lang` switch:

```
dotnet new nunit -lang F#
dotnet new nunit -lang VB
```

> Note that VB doesn't support dashes in project name. If you have `dotnet-new-nunit-example.vbproj` test project, then you'll get compiler error like this:
>
>     vbc : error BC30113: 'dotnet-new-nunit-example' is not a valid name and cannot be used as the root namespace name. [/home/hal/git/dotnet-new-nunit-example/dotnet-new-nunit-example.vbproj]
>
> To workaround this compiler error, rename your project so that it contained no dashes.

### Item templates

To create new C# NUnit test fixture class (with name of folder where it will be created), run:

```
dotnet new nunit-test
```

You can specify filename of test fixture class with `-n` or `--name` parameter:

```
dotnet new nunit-test -n MyTestFixture
```

Unfortunately, this command will create file `MyTestFixture\MyTestFixture.cs`
relatively of current directory.

You can create file `MyTestFixture.cs` in current
directory by overriding output directory with `-o` or `--output` parameter:

```
dotnet new nunit-test -n MyTestFixture -o .
```

If you'd like to create F# or VB test fixture class, you can specify project language with `-lang` switch:

```
dotnet new nunit-test -lang F#
dotnet new nunit-test -lang VB
```

### More information

For more info on `dotnet new` CLI, please read [the documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet).

For more info on NUnit testing framework, see [nunit.org](http://nunit.org/) website.

License
-------

This package is distributed under conditions of [MIT license](LICENSE).
