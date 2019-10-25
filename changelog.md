25 October 2019, 1.7.0
----------------------

- add new `--framework` supported parameters:
    + .NET Core 3.1 version netcoreapp3.1
- update all project templates to default to .NET Core 3.1 (netcoreapp3.1). Other frameworks can still be selected with the `--framework` command line option.

23 October 2019, 1.6.4
----------------------

- update NUnit3TestAdapter to v3.15.1
- update Microsoft.NET.Test.Sdk to v16.3.0

6 August 2019, 1.6.3
--------------------

- update nunit dependency to v3.12.0
- update Microsoft.NET.Test.Sdk dependency to v16.2.0
- F# unit test templates are made module based instead of class based (thanks to [zanaptak](https://github.com/zanaptak), #27)

9 April 2019, 1.6.2
-------------------

- update NUnit3TestAdapter dependency to v3.13.0
- update Microsoft.NET.Test.Sdk dependency to v16.0.1

11 January 2019, 1.6.1
----------------------

- update all project templates to default to .NET Core 3.0 (netcoreapp3.0). Other frameworks can still be selected with the `--framework` command line option.
- update NUnit3TestAdapter dependency to v3.12.0

19 November 2018, 1.6.0
-----------------------

- add new `--framework` supported parameters:
    + .NET Core 2.2 version netcoreapp2.2
    + .NET Core 3.0 version netcoreapp3.0
    + .NET Framework 4.8 version net48
- update all project templates to default to .NET Core 2.2 (netcoreapp2.2). Other frameworks can still be selected with the `--framework` command line option.
- update nunit dependency to v3.11.0
- update NUnit3TestAdapter dependency to v3.11.0
- update Microsoft.NET.Test.Sdk dependency to v15.9.0

23 October 2018, v1.5.3
-----------------------

- Update all project templates to default to .NET Core 2.1 (netcoreapp2.1). Other frameworks can still be selected with the `--framework` command line option.

12 September 2018, v1.5.2
-------------------------

- open UnitTest.cs file when project created in Visual Studio (thanks to [jmarolf](https://github.com/jmarolf), #14)
- update Microsoft.NET.Test.Sdk dependency to v15.8.0

07 May 2018, v1.5.1
-------------------

- fixing regression: `dotnet new nunit` doesn't create project (requiring `--type project` parameter)
    + item templates now has `nunit-test` short name

05 May 2018, v1.5.0
-------------------

- update Microsoft.NET.Test.Sdk dependency to v15.7.2
- add new `--framework` supported parameters:
    + .NET Framework version net472
- add NUnit test fixture item templates

19 March 2018, v1.4.0
---------------------

- update nunit dependency to v3.10.1
- update NUnit3TestAdapter dependency to v3.10.0
- update Microsoft.NET.Test.Sdk dependency to v15.6.1
- add new `--framework` supported parameters:
    + .NET Framework versions (net35, net40, net45, net451, net452, net46, net461, net462, net47, net471)
    + .NET Core 2.1 (netcoreapp2.1)
- add CI using travis-ci (linux, mac osx) and appveyor-ci (windows)

14 November 2017, v1.3.0
------------------------

- update nunit dependency to v3.9.0
- update Microsoft.NET.Test.Sdk dependency to v15.5.0

09 November 2017, v1.2.0
------------------------

- update nunit dependency to v3.8.1
- update NUnit3TestAdapter dependency to v3.9.0
- update Microsoft.NET.Test.Sdk dependency to v15.3.0

24 July 2017, v1.1.0
--------------------

- add support for F# and VB test project templates (thanks to [Echo-8-ERA](https://github.com/Echo-8-ERA))
- update nunit dependency to v3.7.1
- update NUnit3TestAdapter dependency to release v3.8.0

30 May 2017, v1.0.0, v1.0.1
---------------------------

- initial implementation of test project template for C#
