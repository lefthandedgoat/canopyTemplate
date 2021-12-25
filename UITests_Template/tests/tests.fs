module tests

open NUnit.Framework
open canopy.parallell.functions

open baseClass

[<TestFixture>]
type QuotePlusTests() =
    inherit baseClass()

    [<TestCase(TestName="Test1", Category="Tests")>]
        member this.Test1() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test2", Category="Tests")>]
        member this.Test2() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test3", Category="Tests")>]
        member this.Test3() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test4", Category="Tests")>]
        member this.Test4() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test5", Category="Tests")>]
        member this.Test5() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test6", Category="Tests")>]
        member this.Test6() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test7", Category="Tests")>]
        member this.Test7() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test8", Category="Tests")>]
        member this.Test8() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test9", Category="Tests")>]
        member this.Test9() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test10", Category="Tests")>]
        member this.Test10() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test11", Category="Tests")>]
        member this.Test11() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test12", Category="Tests")>]
        member this.Test12() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test13", Category="Tests")>]
        member this.Test13() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test14", Category="Tests")>]
        member this.Test14() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test15", Category="Tests")>]
        member this.Test15() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test16", Category="Tests")>]
        member this.Test16() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test17", Category="Tests")>]
        member this.Test17() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test18", Category="Tests")>]
        member this.Test18() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test19", Category="Tests")>]
        member this.Test19() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test20", Category="Tests")>]
        member this.Test20() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test21", Category="Tests")>]
        member this.Test21() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test22", Category="Tests")>]
        member this.Test22() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test23", Category="Tests")>]
        member this.Test23() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test24", Category="Tests")>]
        member this.Test24() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test25", Category="Tests")>]
        member this.Test25() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test26", Category="Tests")>]
        member this.Test26() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test27", Category="Tests")>]
        member this.Test27() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test28", Category="Tests")>]
        member this.Test28() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test29", Category="Tests")>]
        member this.Test29() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test30", Category="Tests")>]
        member this.Test30() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test31", Category="Tests")>]
        member this.Test31() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test32", Category="Tests")>]
        member this.Test32() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test33", Category="Tests")>]
        member this.Test33() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test34", Category="Tests")>]
        member this.Test34() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test35", Category="Tests")>]
        member this.Test35() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test36", Category="Tests")>]
        member this.Test36() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test37", Category="Tests")>]
        member this.Test37() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test38", Category="Tests")>]
        member this.Test38() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test39", Category="Tests")>]
        member this.Test39() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test40", Category="Tests")>]
        member this.Test40() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test41", Category="Tests")>]
        member this.Test41() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test42", Category="Tests")>]
        member this.Test42() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test43", Category="Tests")>]
        member this.Test43() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test44", Category="Tests")>]
        member this.Test44() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test45", Category="Tests")>]
        member this.Test45() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test46", Category="Tests")>]
        member this.Test46() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test47", Category="Tests")>]
        member this.Test47() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test48", Category="Tests")>]
        member this.Test48() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test49", Category="Tests")>]
        member this.Test49() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest

    [<TestCase(TestName="Test50", Category="Tests")>]
        member this.Test50() =
            fun x ->
                url this.Urls.TestPage x
                testPage.Page.Action.performSomeTestSteps x this.User.LastName this.User.LastName2
                testPage.Assert.lastNameInputCorrect x testPage.Page.Selectors.lastName "Lastname"
            |> runBrowserTest