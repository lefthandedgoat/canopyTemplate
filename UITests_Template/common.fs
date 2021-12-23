module common

open Microsoft.FSharp.Reflection

//helper funcs
let fromString<'a> s =
  match FSharpType.GetUnionCases typeof<'a> |> Array.filter (fun case -> case.Name = s) with
    | [|case|] -> FSharpValue.MakeUnion(case,[||]) :?> 'a
    | _ -> failwith <| sprintf "Can't convert %s to DU" s

let executingDir () = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
//A TestType lets you break tests up in a second way, not by functionality, but maybe by coverage, or environment
type TestType =
  | All
  | UnderDevelopment

type Arguments =
  {
    Browser : canopy.types.BrowserStartMode
    TestType : TestType
  }