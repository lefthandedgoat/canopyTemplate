module baseClass

open System.IO
open System.Collections.Concurrent
open Microsoft.Extensions.Configuration
open canopy.parallell.functions
open canopy.types
open canopy.configuration
open NUnit.Framework
open OpenQA.Selenium
open OpenQA.Selenium.Chrome

module DummyModuleForAttribute =
    [<assembly:LevelOfParallelism(6)>]
    do ()

type ApplicantDetails = {LastName:string;LastName2:string}
type Urls = {TestPage:string}
type canopyTimeOuts = {Element:string;Compare:string;Page:string}
type browserOptions = {Headless:bool}

let private browserDictionary = ConcurrentDictionary<string,IWebDriver>()

let runBrowserTest f =
    let mutable browser:IWebDriver = null
    if browserDictionary.TryGetValue(TestContext.CurrentContext.Test.ID, &browser) then
        f browser
    else sprintf "Could not find browser for test ID %s" TestContext.CurrentContext.Test.ID |> invalidOp

[<Parallelizable(ParallelScope.All)>]
type public baseClass () =

    let config = (new ConfigurationBuilder()).AddJsonFile("appsettings.json").Build()
    member _.User = {LastName=config.["User:LastName"];LastName2=config.["User:LastName2"]}
    member _.Urls = {TestPage=config.["Urls:TestPage"]}
    member _.canopyTimeOuts = {Element= config.["CanopyTimeOuts:ElementTimeOut"];Compare= config.["CanopyTimeOuts:CompareTimeOut"];Page= config.["CanopyTimeOuts:PageTimeOut"]}
    member _.browserOptions = {Headless= config.GetValue<bool>("BrowserOptions:Headless")}

    [<OneTimeSetUp>]
    member this.BeforeAllTests () =
        elementTimeout <- this.canopyTimeOuts.Element |> float
        compareTimeout <- this.canopyTimeOuts.Compare |> float
        pageTimeout <- this.canopyTimeOuts.Page |> float

    [<SetUp>]
    member this.BeforeTest () =

        let instance () =
            let chromeOptions = new ChromeOptions()
            chromeOptions.AddArgument("--ignore-certificate-errors")
            chromeOptions.AddArgument("--allow-insecure-localhost")
            chromeOptions.AddArgument("--no-sandbox")
            chromeOptions.AddArgument("--disable-dev-shm-usage")

            if this.browserOptions.Headless = true then
                chromeOptions.AddArgument("--headless")
                chromeOptions.AddArgument("--disable-gpu")
                chromeOptions.AddArgument("--window-size=1920x1200")
            else
                let buildDir = Directory.GetCurrentDirectory()
                let fullPageScreenCapture = buildDir + @"\ChromeExtensions\FullPageScreenCapture\4.9_0.crx"
                let relativeXPathHelper = buildDir + @"\ChromeExtensions\RelativeXPathHelper\1.2.6_0.crx"
                chromeOptions.AddExtensions(fullPageScreenCapture)
                chromeOptions.AddExtensions(relativeXPathHelper)

            let browser = start <| ChromeWithOptions chromeOptions
            pin FullScreen browser
            browser

        browserDictionary.AddOrUpdate(TestContext.CurrentContext.Test.ID, (fun _ -> instance ()), (fun _ _ -> instance())) |> ignore

        System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") |> sprintf "%s:Test Started" |> TestContext.Out.WriteLine

    [<TearDown>]
    member _.AfterTest () =
        let mutable browser:IWebDriver = null
        if browserDictionary.TryGetValue(TestContext.CurrentContext.Test.ID, &browser) then
            browserDictionary.TryRemove(TestContext.CurrentContext.Test.ID, &browser) |> ignore
            quit browser
        else ()
        System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") |> sprintf "%s:Test Finished" |> TestContext.Out.WriteLine