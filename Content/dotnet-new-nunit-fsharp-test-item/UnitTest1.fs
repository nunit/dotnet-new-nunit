namespace Tests

open NUnit.Framework

type UnitTest1 () =

    [<SetUp>]
    member this.Setup () =
        ()

    [<Test>]
    member this.Test1 () =
        Assert.Pass()
