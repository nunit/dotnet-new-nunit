namespace Company.TestProject1

open NUnit.Framework

type TestClass () =

    [<SetUp>]
    member this.Setup () =
        ()

    [<Test>]
    member this.Test1 () =
        Assert.Pass()
