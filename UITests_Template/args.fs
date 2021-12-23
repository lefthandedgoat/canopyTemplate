module args

open common
open Argu

type private CLIArguments =
  | Browser of string
  | TestType of string
  with
    interface IArgParserTemplate with
      member s.Usage =
        match s with
        | Browser _ -> "specicfy a browser (Chrome Firefox IE)."
        | TestType _ -> "specify testType (All Smoke Full UnderDevelopment)."

let parse cliargs =
  let parser = ArgumentParser.Create<CLIArguments>()
  let results = parser.Parse(cliargs)

  {
    Browser = defaultArg (results.TryPostProcessResult (<@ Browser @>, fromString<canopy.types.BrowserStartMode>)) canopy.types.BrowserStartMode.Chrome
    TestType = defaultArg (results.TryPostProcessResult (<@ TestType @>, fromString<TestType>)) All
  }